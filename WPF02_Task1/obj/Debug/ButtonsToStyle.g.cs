﻿#pragma checksum "..\..\ButtonsToStyle.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A4C10A7710881E4AAC098B29D05A27C1ED52EF2A23DE9B56EE324F2DA14BCF79"
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
using WPF02_Task1;


namespace WPF02_Task1 {
    
    
    /// <summary>
    /// ButtonsToStyle
    /// </summary>
    public partial class ButtonsToStyle : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\ButtonsToStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Style1;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ButtonsToStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Style2;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ButtonsToStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Style3;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ButtonsToStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOne;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ButtonsToStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTwo;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ButtonsToStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnThree;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF02_Task1;component/buttonstostyle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ButtonsToStyle.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Style1 = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\ButtonsToStyle.xaml"
            this.Style1.Click += new System.Windows.RoutedEventHandler(this.changeStyle);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Style2 = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\ButtonsToStyle.xaml"
            this.Style2.Click += new System.Windows.RoutedEventHandler(this.changeStyle);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Style3 = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\ButtonsToStyle.xaml"
            this.Style3.Click += new System.Windows.RoutedEventHandler(this.changeStyle);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnOne = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btnTwo = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.btnThree = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

