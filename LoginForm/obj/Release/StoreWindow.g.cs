#pragma checksum "..\..\StoreWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8442FB9B77354469440AE56953B899EA89A1F395986557C740D1E9568351AC5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LoginForm;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace LoginForm {
    
    
    /// <summary>
    /// StoreWindow
    /// </summary>
    public partial class StoreWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\StoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GraphicsCardTableBtn;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\StoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProcessorTableBtn;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\StoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RAMTableBtn;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\StoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel NavPanel;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\StoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryComboBox;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\StoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchValueTextBox;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\StoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchBtn;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\StoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBtn;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\StoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\StoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid InfoGrid;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\StoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Hint;
        
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
            System.Uri resourceLocater = new System.Uri("/LoginForm;component/storewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StoreWindow.xaml"
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
            this.GraphicsCardTableBtn = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\StoreWindow.xaml"
            this.GraphicsCardTableBtn.Click += new System.Windows.RoutedEventHandler(this.GraphicsCardTableBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ProcessorTableBtn = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\StoreWindow.xaml"
            this.ProcessorTableBtn.Click += new System.Windows.RoutedEventHandler(this.ProcessorTableBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RAMTableBtn = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\StoreWindow.xaml"
            this.RAMTableBtn.Click += new System.Windows.RoutedEventHandler(this.RAMTableBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NavPanel = ((System.Windows.Controls.StackPanel)(target));
            
            #line 116 "..\..\StoreWindow.xaml"
            this.NavPanel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NavPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CategoryComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.SearchValueTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.SearchBtn = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\StoreWindow.xaml"
            this.SearchBtn.Click += new System.Windows.RoutedEventHandler(this.SearchBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.EditBtn = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\StoreWindow.xaml"
            this.EditBtn.Click += new System.Windows.RoutedEventHandler(this.EditBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 173 "..\..\StoreWindow.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.InfoGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 197 "..\..\StoreWindow.xaml"
            this.InfoGrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.InfoGrid_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Hint = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

