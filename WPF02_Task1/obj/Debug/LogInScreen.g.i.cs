﻿#pragma checksum "..\..\LogInScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "223690C62AB8E33DC6DDFB1FBFFA5D03DF9E51BD5277B6797C5CF057EA1AE962"
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
    /// LogInScreen
    /// </summary>
    public partial class LogInScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\LogInScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border profileBorder;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\LogInScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOne;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\LogInScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTwo;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\LogInScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnThree;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\LogInScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFour;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\LogInScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\LogInScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Login;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\LogInScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forget;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\LogInScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewUser;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF02_Task1;component/loginscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LogInScreen.xaml"
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
            this.profileBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.btnOne = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\LogInScreen.xaml"
            this.btnOne.Click += new System.Windows.RoutedEventHandler(this.changeStyle);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnTwo = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\LogInScreen.xaml"
            this.btnTwo.Click += new System.Windows.RoutedEventHandler(this.changeStyle);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnThree = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\LogInScreen.xaml"
            this.btnThree.Click += new System.Windows.RoutedEventHandler(this.changeStyle);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnFour = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\LogInScreen.xaml"
            this.btnFour.Click += new System.Windows.RoutedEventHandler(this.changeStyle);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.Login = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.forget = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.NewUser = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

