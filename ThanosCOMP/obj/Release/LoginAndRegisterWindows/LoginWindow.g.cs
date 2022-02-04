﻿#pragma checksum "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6792D9384AC49DDA41222529987004AE37F94343A7C8B368FC67D7FC76D095CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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
using ThanosCOMP.LoginAndRegisterWindows;


namespace ThanosCOMP.LoginAndRegisterWindows {
    
    
    /// <summary>
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserTextBox;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.IconPacks.PackIconMaterial PasswordIcon;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ForgotPasswordButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ThanosCOMP-part2;component/loginandregisterwindows/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
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
            
            #line 11 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
            ((ThanosCOMP.LoginAndRegisterWindows.LoginWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 36 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
            ((MahApps.Metro.IconPacks.PackIconMaterial)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.close);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UserTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
            this.UserTextBox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.UserTextBox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
            this.UserTextBox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.UserTextBox_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 95 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
            this.PasswordBox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.PasswordBox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 95 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
            this.PasswordBox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.PasswordBox_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PasswordIcon = ((MahApps.Metro.IconPacks.PackIconMaterial)(target));
            return;
            case 6:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ForgotPasswordButton = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\LoginAndRegisterWindows\LoginWindow.xaml"
            this.ForgotPasswordButton.Click += new System.Windows.RoutedEventHandler(this.ForgotPasswordButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

