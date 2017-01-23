﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PicView.lib.UserControls
{
    /// <summary>
    /// Interaction logic for QuickSettingsMenu.xaml
    /// </summary>
    public partial class QuickSettingsMenu : UserControl
    {
        public QuickSettingsMenu()
        {
            InitializeComponent();

            #region Register events
            CloseButton.MouseEnter += CloseButtonMouseOver;
            CloseButton.MouseLeave += CloseButtonMouseLeave;
            CloseButton.PreviewMouseLeftButtonDown += CloseButtonMouseButtonDown;

            fill.PreviewMouseLeftButtonDown += fill_PreviewMouseLeftButtonDown;
            fill.MouseEnter += fill_MouseEnter;
            fill.MouseLeave += fill_MouseLeave;

            fit.PreviewMouseLeftButtonDown += fit_PreviewMouseLeftButtonDown;
            fit.MouseEnter += fit_MouseEnter;
            fit.MouseLeave += fit_MouseLeave;

            center.PreviewMouseLeftButtonDown += center_PreviewMouseLeftButtonDown;
            center.MouseEnter += center_MouseEnter;
            center.MouseLeave += center_MouseLeave;

            tile.PreviewMouseLeftButtonDown += tile_PreviewMouseLeftButtonDown;
            tile.MouseEnter += tile_MouseEnter;
            tile.MouseLeave += tile_MouseLeave;

            stretch.PreviewMouseLeftButtonDown += stretch_PreviewMouseLeftButtonDown;
            stretch.MouseEnter += stretch_MouseEnter;
            stretch.MouseLeave += stretch_MouseLeave;

            ToggleScroll.PreviewMouseLeftButtonDown += ToggleScroll_PreviewMouseLeftButtonDown;
            ToggleScroll.MouseEnter += ToggleScroll_MouseEnter;
            ToggleScroll.MouseLeave += ToggleScroll_MouseLeave;

            SetFit.PreviewMouseLeftButtonDown += SetFit_PreviewMouseLeftButtonDown;
            SetFit.MouseEnter += SetFit_MouseEnter;
            SetFit.MouseLeave += SetFit_MouseLeave;

            blueradio.PreviewMouseLeftButtonDown += blueradio_PreviewMouseLeftButtonDown;
            blueradio.MouseEnter += blueradio_MouseEnter;
            blueradio.MouseLeave += blueradio_MouseLeave;

            pinkradio.PreviewMouseLeftButtonDown += pinkradio_PreviewMouseLeftButtonDown;
            pinkradio.MouseEnter += pinkradio_MouseEnter;
            pinkradio.MouseLeave += pinkradio_MouseLeave;

            orangeradio.PreviewMouseLeftButtonDown += orangeradio_PreviewMouseLeftButtonDown;
            orangeradio.MouseEnter += orangeradio_MouseEnter;
            orangeradio.MouseLeave += orangeradio_MouseLeave;

            greenradio.PreviewMouseLeftButtonDown += greenradio_PreviewMouseLeftButtonDown;
            greenradio.MouseEnter += greenradio_MouseEnter;
            greenradio.MouseLeave += greenradio_MouseLeave;

            redradio.PreviewMouseLeftButtonDown += redradio_PreviewMouseLeftButtonDown;
            redradio.MouseEnter += redradio_MouseEnter;
            redradio.MouseLeave += redradio_MouseLeave;

            tealradio.PreviewMouseLeftButtonDown += tealradio_PreviewMouseLeftButtonDown;
            tealradio.MouseEnter += tealradio_MouseEnter;
            tealradio.MouseLeave += tealradio_MouseLeave;

            aquaradio.PreviewMouseLeftButtonDown += aquaradio_PreviewMouseLeftButtonDown;
            aquaradio.MouseEnter += aquaradio_MouseEnter;
            aquaradio.MouseLeave += aquaradio_MouseLeave;

            sandyradio.PreviewMouseLeftButtonDown += sandyradio_PreviewMouseLeftButtonDown;
            sandyradio.MouseEnter += sandyradio_MouseEnter;
            sandyradio.MouseLeave += sandyradio_MouseLeave;

            purpleradio.PreviewMouseLeftButtonDown += purpleradio_PreviewMouseLeftButtonDown;
            purpleradio.MouseEnter += purpleradio_MouseEnter;
            purpleradio.MouseLeave += purpleradio_MouseLeave;

            cyanradio.PreviewMouseLeftButtonDown += cyanradio_PreviewMouseLeftButtonDown;
            cyanradio.MouseEnter += cyanradio_MouseEnter;
            cyanradio.MouseLeave += cyanradio_MouseLeave;

            magentaradio.PreviewMouseLeftButtonDown += magentaradio_PreviewMouseLeftButtonDown;
            magentaradio.MouseEnter += magentaradio_MouseEnter;
            magentaradio.MouseLeave += magentaradio_MouseLeave;

            yellowradio.PreviewMouseLeftButtonDown += yellowradio_PreviewMouseLeftButtonDown;
            yellowradio.MouseEnter += yellowradio_MouseEnter;
            yellowradio.MouseLeave += yellowradio_MouseLeave;
            #endregion
        }

        #region Close Button

        private void CloseButtonMouseOver(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(255, 15, 15, 15, CloseButtonBrush, false);
        }

        private void CloseButtonMouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(CloseButtonBrush, false);
        }

        private void CloseButtonMouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(255, 15, 15, 15, CloseButtonBrush, false);
        }

        #endregion

        #region fillbutton Mouse Event
        void fill_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, fillBrush, false);
        }

        void fill_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, fillBrush, false);
        }

        void fill_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(fillBrush, false);
        }

        #endregion

        #region tilebutton Mouse Event
        void tile_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, tileBrush, false);
        }

        void tile_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, tileBrush, false);
        }

        void tile_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(tileBrush, false);
        }

        #endregion

        #region centerbutton Mouse Event
        void center_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, centerBrush, false);
        }

        void center_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, centerBrush, false);
        }

        void center_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(centerBrush, false);
        }

        #endregion

        #region fitbutton Mouse Event
        void fit_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, fitBrush, false);
        }

        void fit_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, fitBrush, false);
        }

        void fit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(fitBrush, false);
        }

        #endregion

        #region stretchutton Mouse Event
        void stretch_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, stretchBrush, false);
        }

        void stretch_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, stretchBrush, false);
        }

        void stretch_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(stretchBrush, false);
        }

        #endregion

        #region SetFitbutton Mouse Event
        void SetFit_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, SetFitBrush, false);
        }

        void SetFit_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, SetFitBrush, false);
        }

        void SetFit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(SetFitBrush, false);
        }

        #endregion

        #region ToggleScroll Mouse Event
        void ToggleScroll_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, ToggleScrollBrush, false);
        }

        void ToggleScroll_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, ToggleScrollBrush, false);
        }

        void ToggleScroll_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(ToggleScrollBrush, false);
        }

        #endregion

        #region ColorTheme Mouse Events

        #region Blue

        void blueradio_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, blueBrush, 1);
        }

        void blueradio_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, blueBrush, 1);
        }

        void blueradio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(blueBrush, 1);
        }

        #endregion

        #region pink

        void pinkradio_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, pinkBrush, 2);
        }

        void pinkradio_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, pinkBrush, 2);
        }

        void pinkradio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(pinkBrush, 2);
        }

        #endregion

        #region orange

        void orangeradio_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, orangeBrush, 3);
        }

        void orangeradio_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, orangeBrush, 3);
        }

        void orangeradio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(orangeBrush, 3);
        }

        #endregion

        #region green

        void greenradio_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, greenBrush, 4);
        }

        void greenradio_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, greenBrush, 4);
        }

        void greenradio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(greenBrush, 4);
        }

        #endregion

        #region red

        void redradio_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, redBrush, 5);
        }

        void redradio_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, redBrush, 5);
        }

        void redradio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(redBrush, 5);
        }

        #endregion

        #region teal

        void tealradio_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, tealBrush, 6);
        }

        void tealradio_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, tealBrush, 6);
        }

        void tealradio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(tealBrush, 6);
        }

        #endregion

        #region aqua

        void aquaradio_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, aquaBrush, 7);
        }

        void aquaradio_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, aquaBrush, 7);
        }

        void aquaradio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(aquaBrush, 7);
        }

        #endregion

        #region sandy

        void sandyradio_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, sandyBrush, 8);
        }

        void sandyradio_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, sandyBrush, 8);
        }

        void sandyradio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(sandyBrush, 8);
        }

        #endregion

        #region purple

        void purpleradio_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, purpleBrush, 9);
        }

        void purpleradio_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, purpleBrush, 9);
        }

        void purpleradio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(purpleBrush, 9);
        }

        #endregion

        #region Cyan

        void cyanradio_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, cyanBrush, 10);
        }

        void cyanradio_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, cyanBrush, 10);
        }

        void cyanradio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(cyanBrush, 10);
        }

        #endregion

        #region magenta

        void magentaradio_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, magentaBrush, 11);
        }

        void magentaradio_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, magentaBrush, 11);
        }

        void magentaradio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(magentaBrush, 11);
        }

        #endregion

        #region yellow

        void yellowradio_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseLeaveColorEvent(165, 35, 35, 35, yellowBrush, 12);
        }

        void yellowradio_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHelper.MouseEnterColorEvent(165, 35, 35, 35, yellowBrush, 12);
        }

        void yellowradio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationHelper.PreviewMouseLeftButtonDownColorEvent(yellowBrush, 12);
        }

        #endregion

        #endregion
    }
}