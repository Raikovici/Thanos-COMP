﻿#pragma checksum "..\..\..\AdminWindows\ModifyProductWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C8C8BB48E4B109D8B6E3F49A0AF742596D77DCADCD5FFBCBEFE5E47EDFF50935"
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
    /// ModifyProductWindow
    /// </summary>
    public partial class ModifyProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\AdminWindows\ModifyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryPicker;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\AdminWindows\ModifyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProductPicker;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\AdminWindows\ModifyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FieldPicker;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\AdminWindows\ModifyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ValueTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\AdminWindows\ModifyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModifyButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\AdminWindows\ModifyProductWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ThanosCOMP-part2;component/adminwindows/modifyproductwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminWindows\ModifyProductWindow.xaml"
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
            this.CategoryPicker = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\..\AdminWindows\ModifyProductWindow.xaml"
            this.CategoryPicker.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CategoryPicker_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ProductPicker = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\AdminWindows\ModifyProductWindow.xaml"
            this.ProductPicker.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductPicker_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FieldPicker = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\AdminWindows\ModifyProductWindow.xaml"
            this.FieldPicker.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FieldPicker_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ValueTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ModifyButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\AdminWindows\ModifyProductWindow.xaml"
            this.ModifyButton.Click += new System.Windows.RoutedEventHandler(this.ModifyButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\AdminWindows\ModifyProductWindow.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

