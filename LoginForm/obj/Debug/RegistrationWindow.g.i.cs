﻿#pragma checksum "..\..\RegistrationWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8A2FF7FE20884A85AE5A3A8D7FBF00932BB5BBA9CBE08A49A99E7891E8810E81"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
    /// RegistrationWindow
    /// </summary>
    public partial class RegistrationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 116 "..\..\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid NavPanel;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close;
        
        #line default
        #line hidden
        
        
        #line 298 "..\..\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginBox;
        
        #line default
        #line hidden
        
        
        #line 311 "..\..\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WrongLoginLabel;
        
        #line default
        #line hidden
        
        
        #line 328 "..\..\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 342 "..\..\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WrongPasswordLabel;
        
        #line default
        #line hidden
        
        
        #line 359 "..\..\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailBox;
        
        #line default
        #line hidden
        
        
        #line 372 "..\..\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WrongEmailLabel;
        
        #line default
        #line hidden
        
        
        #line 391 "..\..\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameBox;
        
        #line default
        #line hidden
        
        
        #line 407 "..\..\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameBox;
        
        #line default
        #line hidden
        
        
        #line 416 "..\..\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/LoginForm;component/registrationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegistrationWindow.xaml"
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
            this.NavPanel = ((System.Windows.Controls.Grid)(target));
            
            #line 118 "..\..\RegistrationWindow.xaml"
            this.NavPanel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NavPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Close = ((System.Windows.Controls.Button)(target));
            
            #line 142 "..\..\RegistrationWindow.xaml"
            this.Close.Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LoginBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.WrongLoginLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.WrongPasswordLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.EmailBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.WrongEmailLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.NameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.LastNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.RegisterBtn = ((System.Windows.Controls.Button)(target));
            
            #line 418 "..\..\RegistrationWindow.xaml"
            this.RegisterBtn.Click += new System.Windows.RoutedEventHandler(this.RegisterBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

