﻿#pragma checksum "..\..\..\InitialSettings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DAB688D12BC09213626E03BA305D2FA39320B833"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPFapp;


namespace WPFapp {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\InitialSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblGender;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\InitialSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMale;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\InitialSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFemale;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\InitialSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLanguage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\InitialSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnglish;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\InitialSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCroatian;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\InitialSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNationalTeam;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\InitialSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbChampionship;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\InitialSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\InitialSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNext;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\InitialSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\InitialSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblErrMsg;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFapp;component/initialsettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\InitialSettings.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblGender = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnMale = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\InitialSettings.xaml"
            this.btnMale.Click += new System.Windows.RoutedEventHandler(this.btnMale_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnFemale = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\InitialSettings.xaml"
            this.btnFemale.Click += new System.Windows.RoutedEventHandler(this.btnFemale_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblLanguage = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnEnglish = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\InitialSettings.xaml"
            this.btnEnglish.Click += new System.Windows.RoutedEventHandler(this.btnEnglish_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCroatian = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\InitialSettings.xaml"
            this.btnCroatian.Click += new System.Windows.RoutedEventHandler(this.btnCroatian_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblNationalTeam = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.cbChampionship = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\..\InitialSettings.xaml"
            this.cbChampionship.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbChampionship_SelectedIndexChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\InitialSettings.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnNext = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\InitialSettings.xaml"
            this.btnNext.Click += new System.Windows.RoutedEventHandler(this.btnNext_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\InitialSettings.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lblErrMsg = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
