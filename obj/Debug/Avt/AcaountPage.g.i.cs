﻿#pragma checksum "..\..\..\Avt\AcaountPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "96C4563564225672209ACB067DA2EEBC4B32F6FA13500928786CD099EA54AB05"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LISTURLIC.Avt;
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


namespace LISTURLIC.Avt {
    
    
    /// <summary>
    /// AcaountPage
    /// </summary>
    public partial class AcaountPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Avt\AcaountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FioTxt;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Avt\AcaountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PostTxt;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Avt\AcaountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EndBtn;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Avt\AcaountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ListBtn;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Avt\AcaountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Avt\AcaountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UserBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/LISTURLIC;component/avt/acaountpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Avt\AcaountPage.xaml"
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
            this.FioTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PostTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.EndBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Avt\AcaountPage.xaml"
            this.EndBtn.Click += new System.Windows.RoutedEventHandler(this.EndBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListBtn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Avt\AcaountPage.xaml"
            this.ListBtn.Click += new System.Windows.RoutedEventHandler(this.ListBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Avt\AcaountPage.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UserBtn = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Avt\AcaountPage.xaml"
            this.UserBtn.Click += new System.Windows.RoutedEventHandler(this.UserBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
