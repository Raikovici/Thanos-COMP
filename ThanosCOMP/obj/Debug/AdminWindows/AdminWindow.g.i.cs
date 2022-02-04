﻿#pragma checksum "..\..\..\AdminWindows\AdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A452A0D468A664A6C9551E37583601D5FB0597BE265C4841181E1C8F2CBAFA53"
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
using ThanosCOMP.AdminWindows;


namespace ThanosCOMP.AdminWindows {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 71 "..\..\..\AdminWindows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowAccountsButton;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\AdminWindows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModifyAccountButton;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\AdminWindows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteAccountButton;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\AdminWindows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddProductButton;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\AdminWindows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModifyProductButton;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\AdminWindows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteProductButton;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\AdminWindows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogOut;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\AdminWindows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddStockButton;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\AdminWindows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddSupplierButton;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\AdminWindows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddShipperButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ThanosCOMP-part2;component/adminwindows/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminWindows\AdminWindow.xaml"
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
            
            #line 12 "..\..\..\AdminWindows\AdminWindow.xaml"
            ((ThanosCOMP.AdminWindows.AdminWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ShowAccountsButton = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\AdminWindows\AdminWindow.xaml"
            this.ShowAccountsButton.Click += new System.Windows.RoutedEventHandler(this.ShowAccountsButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ModifyAccountButton = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\AdminWindows\AdminWindow.xaml"
            this.ModifyAccountButton.Click += new System.Windows.RoutedEventHandler(this.ModifyAccountButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteAccountButton = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\AdminWindows\AdminWindow.xaml"
            this.DeleteAccountButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 124 "..\..\..\AdminWindows\AdminWindow.xaml"
            this.AddProductButton.Click += new System.Windows.RoutedEventHandler(this.AddProductButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ModifyProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 137 "..\..\..\AdminWindows\AdminWindow.xaml"
            this.ModifyProductButton.Click += new System.Windows.RoutedEventHandler(this.ModifyProductButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 150 "..\..\..\AdminWindows\AdminWindow.xaml"
            this.DeleteProductButton.Click += new System.Windows.RoutedEventHandler(this.DeleteProductButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.LogOut = ((System.Windows.Controls.Button)(target));
            
            #line 165 "..\..\..\AdminWindows\AdminWindow.xaml"
            this.LogOut.Click += new System.Windows.RoutedEventHandler(this.LogOut_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddStockButton = ((System.Windows.Controls.Button)(target));
            
            #line 181 "..\..\..\AdminWindows\AdminWindow.xaml"
            this.AddStockButton.Click += new System.Windows.RoutedEventHandler(this.AddStockButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AddSupplierButton = ((System.Windows.Controls.Button)(target));
            
            #line 194 "..\..\..\AdminWindows\AdminWindow.xaml"
            this.AddSupplierButton.Click += new System.Windows.RoutedEventHandler(this.AddSupplierButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.AddShipperButton = ((System.Windows.Controls.Button)(target));
            
            #line 206 "..\..\..\AdminWindows\AdminWindow.xaml"
            this.AddShipperButton.Click += new System.Windows.RoutedEventHandler(this.AddShipperButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

