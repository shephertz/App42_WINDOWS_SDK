﻿#pragma checksum "C:\Users\Sachin\Desktop\SSSS\WINDOWS\Windows_Phone_SDK\sample\leaderboard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "25CF612E170413D8338484E612621474"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
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


namespace App42Sample {
    
    
    public partial class leaderboard : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Grid grdContentHighScores;
        
        internal System.Windows.Controls.Grid grdContentHeadersHighScore;
        
        internal System.Windows.Controls.Border tblRankHighscores;
        
        internal System.Windows.Controls.Border tblNameHighscores;
        
        internal System.Windows.Controls.Border tblScoreHighscores;
        
        internal System.Windows.Controls.ListBox lbxGlobalScore;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/App42Sample;component/leaderboard.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.grdContentHighScores = ((System.Windows.Controls.Grid)(this.FindName("grdContentHighScores")));
            this.grdContentHeadersHighScore = ((System.Windows.Controls.Grid)(this.FindName("grdContentHeadersHighScore")));
            this.tblRankHighscores = ((System.Windows.Controls.Border)(this.FindName("tblRankHighscores")));
            this.tblNameHighscores = ((System.Windows.Controls.Border)(this.FindName("tblNameHighscores")));
            this.tblScoreHighscores = ((System.Windows.Controls.Border)(this.FindName("tblScoreHighscores")));
            this.lbxGlobalScore = ((System.Windows.Controls.ListBox)(this.FindName("lbxGlobalScore")));
        }
    }
}

