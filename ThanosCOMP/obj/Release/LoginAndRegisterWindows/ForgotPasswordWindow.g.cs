﻿#pragma checksum "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "37C74CD916B65B88FAF84494ABB7385D080F6568F5458B7CA28DE60CFF123A4A"
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


namespace ThanosCOMP.LoginAndRegisterWindows {
    
    
    /// <summary>
    /// ForgotPasswordWindow
    /// </summary>
    public partial class ForgotPasswordWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserTextBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PwdTextBox;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConfirmPasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ConfirmPwdBox;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ThanosCOMP-part2;component/loginandregisterwindows/forgotpasswordwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
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
            
            #line 10 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
            ((ThanosCOMP.LoginAndRegisterWindows.ForgotPasswordWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 36 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
            ((MahApps.Metro.IconPacks.PackIconMaterial)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PackIconMaterial_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UserTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
            this.UserTextBox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.UserTextBox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
            this.UserTextBox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.UserTextBox_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PwdTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 89 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
            this.PwdTextBox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.PwdTextBox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 89 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
            this.PwdTextBox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.PwdTextBox_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ConfirmPasswordTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 112 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
            this.ConfirmPasswordTextBox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.UserTextBox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 112 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
            this.ConfirmPasswordTextBox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.UserTextBox_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ConfirmPwdBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 129 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
            this.ConfirmPwdBox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ConfirmPwdBox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 129 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
            this.ConfirmPwdBox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ConfirmPwdBox_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 148 "..\..\..\LoginAndRegisterWindows\ForgotPasswordWindow.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

