﻿#pragma checksum "..\..\WindControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F177D10EDCD773EC340FC60AB01D89EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FireApp;
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


namespace FireApp {
    
    
    /// <summary>
    /// WindControl
    /// </summary>
    public partial class WindControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\WindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _NoWind;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _LightWind;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _ModerateWind;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\WindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _StrongWind;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\WindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _NW;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\WindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _N;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\WindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _NE;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\WindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _W;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\WindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _E;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\WindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _SW;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\WindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _S;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\WindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _SE;
        
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
            System.Uri resourceLocater = new System.Uri("/FireApp;component/windcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindControl.xaml"
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
            this._NoWind = ((System.Windows.Controls.RadioButton)(target));
            
            #line 10 "..\..\WindControl.xaml"
            this._NoWind.Checked += new System.Windows.RoutedEventHandler(this.WindStrengthRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this._LightWind = ((System.Windows.Controls.RadioButton)(target));
            
            #line 12 "..\..\WindControl.xaml"
            this._LightWind.Checked += new System.Windows.RoutedEventHandler(this.WindStrengthRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this._ModerateWind = ((System.Windows.Controls.RadioButton)(target));
            
            #line 14 "..\..\WindControl.xaml"
            this._ModerateWind.Checked += new System.Windows.RoutedEventHandler(this.WindStrengthRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this._StrongWind = ((System.Windows.Controls.RadioButton)(target));
            
            #line 16 "..\..\WindControl.xaml"
            this._StrongWind.Checked += new System.Windows.RoutedEventHandler(this.WindStrengthRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this._NW = ((System.Windows.Controls.RadioButton)(target));
            
            #line 34 "..\..\WindControl.xaml"
            this._NW.Checked += new System.Windows.RoutedEventHandler(this._DirectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this._N = ((System.Windows.Controls.RadioButton)(target));
            
            #line 42 "..\..\WindControl.xaml"
            this._N.Checked += new System.Windows.RoutedEventHandler(this._DirectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this._NE = ((System.Windows.Controls.RadioButton)(target));
            
            #line 48 "..\..\WindControl.xaml"
            this._NE.Checked += new System.Windows.RoutedEventHandler(this._DirectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this._W = ((System.Windows.Controls.RadioButton)(target));
            
            #line 55 "..\..\WindControl.xaml"
            this._W.Checked += new System.Windows.RoutedEventHandler(this._DirectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this._E = ((System.Windows.Controls.RadioButton)(target));
            
            #line 64 "..\..\WindControl.xaml"
            this._E.Checked += new System.Windows.RoutedEventHandler(this._DirectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this._SW = ((System.Windows.Controls.RadioButton)(target));
            
            #line 70 "..\..\WindControl.xaml"
            this._SW.Checked += new System.Windows.RoutedEventHandler(this._DirectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this._S = ((System.Windows.Controls.RadioButton)(target));
            
            #line 78 "..\..\WindControl.xaml"
            this._S.Checked += new System.Windows.RoutedEventHandler(this._DirectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this._SE = ((System.Windows.Controls.RadioButton)(target));
            
            #line 85 "..\..\WindControl.xaml"
            this._SE.Checked += new System.Windows.RoutedEventHandler(this._DirectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

