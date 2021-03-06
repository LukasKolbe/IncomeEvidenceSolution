﻿#pragma checksum "..\..\..\Resources\BalanceOverview.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06F951D78AB81C4D81038AFBB175B6C212096A3D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IncomeEvidenceOSVC.Properties;
using IncomeEvidenceOSVC.Resources;
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


namespace IncomeEvidenceOSVC.Resources {
    
    
    /// <summary>
    /// BalanceOverview
    /// </summary>
    public partial class BalanceOverview : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 13 "..\..\..\Resources\BalanceOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid OverviewGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Resources\BalanceOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView DailyBalanceList;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Resources\BalanceOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SummaryIncome;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\Resources\BalanceOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SummaryCosts;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\Resources\BalanceOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Gain;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Resources\BalanceOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewRecordButton;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Resources\BalanceOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveRecordButton;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\Resources\BalanceOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditRecordButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Money Control;component/resources/balanceoverview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Resources\BalanceOverview.xaml"
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
            
            #line 9 "..\..\..\Resources\BalanceOverview.xaml"
            ((IncomeEvidenceOSVC.Resources.BalanceOverview)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OverviewGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.DailyBalanceList = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.SummaryIncome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.SummaryCosts = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Gain = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.NewRecordButton = ((System.Windows.Controls.Button)(target));
            
            #line 137 "..\..\..\Resources\BalanceOverview.xaml"
            this.NewRecordButton.Click += new System.Windows.RoutedEventHandler(this.AddNewRecord_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.RemoveRecordButton = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\..\Resources\BalanceOverview.xaml"
            this.RemoveRecordButton.Click += new System.Windows.RoutedEventHandler(this.RemoveRecord_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EditRecordButton = ((System.Windows.Controls.Button)(target));
            
            #line 155 "..\..\..\Resources\BalanceOverview.xaml"
            this.EditRecordButton.Click += new System.Windows.RoutedEventHandler(this.EditRecord_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 4:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 29 "..\..\..\Resources\BalanceOverview.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ListViewItem_MouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

