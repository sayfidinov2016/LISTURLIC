﻿#pragma checksum "..\..\..\..\Avt\List\ListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "90BB31292909744682D7E3F20141280FD6D3497218D77262CC252FAF12B98E32"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LISTURLIC.Avt.List;
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


namespace LISTURLIC.Avt.List {
    
    
    /// <summary>
    /// ListPage
    /// </summary>
    public partial class ListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Avt\List\ListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PoiskTxt;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Avt\List\ListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ListOrgn;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Avt\List\ListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EndBtn;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Avt\List\ListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VodBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/LISTURLIC;component/avt/list/listpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Avt\List\ListPage.xaml"
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
            this.PoiskTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ListOrgn = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.EndBtn = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\Avt\List\ListPage.xaml"
            this.EndBtn.Click += new System.Windows.RoutedEventHandler(this.EndBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.VodBtn = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\Avt\List\ListPage.xaml"
            this.VodBtn.Click += new System.Windows.RoutedEventHandler(this.VodBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

