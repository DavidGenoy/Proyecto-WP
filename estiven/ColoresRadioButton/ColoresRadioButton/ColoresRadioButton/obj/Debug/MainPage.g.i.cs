﻿#pragma checksum "C:\Users\ç\Documents\Visual Studio 2012\Projects\ColoresRadioButton\ColoresRadioButton\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CB8CC1D6799398BF905389852DA676E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ColoresRadioButton {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock hexTitle;
        
        internal System.Windows.Controls.TextBlock nameColorTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.RadioButton btnAzul;
        
        internal System.Windows.Controls.RadioButton btnAmarillo;
        
        internal System.Windows.Controls.RadioButton btnRojo;
        
        internal System.Windows.Shapes.Rectangle rectangulo;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/ColoresRadioButton;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.hexTitle = ((System.Windows.Controls.TextBlock)(this.FindName("hexTitle")));
            this.nameColorTitle = ((System.Windows.Controls.TextBlock)(this.FindName("nameColorTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btnAzul = ((System.Windows.Controls.RadioButton)(this.FindName("btnAzul")));
            this.btnAmarillo = ((System.Windows.Controls.RadioButton)(this.FindName("btnAmarillo")));
            this.btnRojo = ((System.Windows.Controls.RadioButton)(this.FindName("btnRojo")));
            this.rectangulo = ((System.Windows.Shapes.Rectangle)(this.FindName("rectangulo")));
        }
    }
}
