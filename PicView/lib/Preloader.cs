﻿using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using static PicView.lib.Helper;

namespace PicView.lib
{
    internal static class Preloader
    {
        private static readonly ConcurrentDictionary<string, BitmapSource> Sources = new ConcurrentDictionary<string, BitmapSource>();

        internal static void Add(string file)
        {
            if (Contains(file))
                return;
            var ext = Path.GetExtension(file);
            if (ext == ".gif")
                return;
            var pic = ImageManager.RenderToBitmapSource(file, ext);
            if (pic == null)
                return;
            pic.Freeze();
            Sources.TryAdd(file, pic);
        }

        internal static BitmapSource Load(string file)
        {
            if (!Contains(file))
                return null;

            return Sources[file];
        }

        internal static void Add(int i)
        {
            if (i >= Pics.Count || i < 0)
                return;

            if (File.Exists(Pics[i]))
            {
                if (!Contains(Pics[i]))
                    Add(Pics[i]);
            }
            else
                Pics.Remove(Pics[i]);
        }

        internal static void Add(BitmapSource bmp, string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return;
            if (Contains(key))
                return;
            if (bmp == null)
                return;
            if (!bmp.IsFrozen)
                bmp.Freeze();
            Sources.TryAdd(key, bmp);
        }

        internal static bool Contains(string key)
        {
            return Sources.ContainsKey(key);
        }

        internal static void Remove(string key)
        {
            if (key == null) return;
            if (!Contains(key)) return;

            var value = Sources[key];
            Sources.TryRemove(key, out value);
            value = null;
        }

        internal static void Clear()
        {
            var array = Sources.Keys.ToArray();

            var timer = new DispatcherTimer
            (
                TimeSpan.FromSeconds(40), DispatcherPriority.ContextIdle, (s, e) => {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Remove(array[i]);
                    }
                    //GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
                    GC.Collect();
                },
                Application.Current.Dispatcher
            );
            timer.Start();
        }

        internal static void Clear(string[] array)
        {
            var timer = new DispatcherTimer
            (
                TimeSpan.FromMinutes(1.5), DispatcherPriority.ContextIdle, (s, e) =>
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Remove(array[i]);
                    }
                    //GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
                    GC.Collect();
                },
                Application.Current.Dispatcher
            );
            timer.Start();
        }

        internal static int Count()
        {
            return Sources.Count;
        }

        #region Preloading
        /// <summary>
        /// Starts decoding images into memory,
        /// based on current index and if reverse or not
        /// </summary>
        /// <param name="index"></param>
        /// <param name="reverse"></param>
        internal static void PreLoad(int index, bool reverse)
        {
            #region Forward
            if (!reverse)
            {
                //Add first three
                var i = index + 1 >= Pics.Count ? (index + 1) - Pics.Count : index + 1;
                Add(i);
                i = i + 1 >= Pics.Count ? (i + 1) - Pics.Count : i + 1;
                Add(i);
                i = i + 1 >= Pics.Count ? (i + 1) - Pics.Count : i + 1;
                Add(i);

                //Add two behind
                i = index - 1 < 0 ? Pics.Count - index : index - 1;
                Add(i);
                i = i - 1 < 0 ? Pics.Count - i : i - 1;
                Add(i);

                //Add one more infront
                i = index + 4 >= Pics.Count ? (index + 4) - Pics.Count : index + 4;
                Add(i);

                if (!freshStartup)
                {
                    //Clean up behind
                    var arr = new string[3];
                    i = index - 3 < 0 ? (Pics.Count - index) - 3 : index - 3;
                    if (i > -1 && i < Pics.Count)
                        arr[0] = Pics[i];
                    i = i - 1 < 0 ? (Pics.Count - index) - 1 : i - 1;
                    if (i > -1 && i < Pics.Count)
                        arr[1] = Pics[i];
                    i = i - 1 < 0 ? (Pics.Count - index) - 1 : i - 1;
                    if (i > -1 && i < Pics.Count)
                        arr[2] = Pics[i];
                    Clear(arr);
                }
            }
            #endregion

            #region Backwards
            else
            {
                //Add first three
                var i = index - 1 < 0 ? Pics.Count : index - 1;
                Add(i);
                i = i - 1 < 0 ? Pics.Count : i - 1;
                Add(i);
                i = i - 1 < 0 ? Pics.Count : i - 1;
                Add(i);

                //Add two behind
                i = index + 1 >= Pics.Count ? (i + 1) - Pics.Count : index + 1;
                Add(i);
                i = i + 1 >= Pics.Count ? (i + 1) - Pics.Count : i + 1;
                Add(i);

                //Add one more infront
                i = index - 4 < 0 ? (index + 4) - Pics.Count : index - 4;
                Add(i);

                if (!freshStartup)
                {
                    //Clean up behind
                    var arr = new string[3];
                    i = index + 3 > Pics.Count - 1 ? Pics.Count - 1 : index + 3;
                    arr[0] = Pics[i];
                    i = index + 4 > Pics.Count - 1 ? Pics.Count - 1 : index + 4;
                    arr[1] = Pics[i];
                    i = index + 5 > Pics.Count - 1 ? Pics.Count - 1 : index + 5;
                    arr[2] = Pics[i];
                    Clear(arr);
                }
            }
            #endregion
        }

        #endregion
    }

}