﻿#pragma checksum "..\..\Controls.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DB423E490E1A05EEB68C2A7BD854FE8E49DC21BDD2405AF3D2DFD4BBFD2125D0"
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
using wk4cls3;


namespace wk4cls3 {
    
    
    /// <summary>
    /// Controls
    /// </summary>
    public partial class Controls : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Controls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Controls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button lb_Selection;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Controls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Controls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmBxSelection;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Controls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxOne;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Controls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button checkButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Controls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Controls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxTwo;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Controls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxThird;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Controls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxFour;
        
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
            System.Uri resourceLocater = new System.Uri("/wk4cls3;component/controls.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Controls.xaml"
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
            this.listBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 10 "..\..\Controls.xaml"
            this.listBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lb_Selection = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Controls.xaml"
            this.lb_Selection.Click += new System.Windows.RoutedEventHandler(this.lb_Selection_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\Controls.xaml"
            this.comboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmBxSelection = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Controls.xaml"
            this.cmBxSelection.Click += new System.Windows.RoutedEventHandler(this.cmBxSelection_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.checkBoxOne = ((System.Windows.Controls.CheckBox)(target));
            
            #line 30 "..\..\Controls.xaml"
            this.checkBoxOne.Checked += new System.Windows.RoutedEventHandler(this.checkBoxOne_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.checkButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Controls.xaml"
            this.checkButton.Click += new System.Windows.RoutedEventHandler(this.checkButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.checkBoxTwo = ((System.Windows.Controls.CheckBox)(target));
            
            #line 33 "..\..\Controls.xaml"
            this.checkBoxTwo.Checked += new System.Windows.RoutedEventHandler(this.checkBoxTwo_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.checkBoxThird = ((System.Windows.Controls.CheckBox)(target));
            
            #line 34 "..\..\Controls.xaml"
            this.checkBoxThird.Checked += new System.Windows.RoutedEventHandler(this.checkBoxThird_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.checkBoxFour = ((System.Windows.Controls.CheckBox)(target));
            
            #line 35 "..\..\Controls.xaml"
            this.checkBoxFour.Checked += new System.Windows.RoutedEventHandler(this.checkBoxFour_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

