﻿#pragma checksum "..\..\..\View\Serial_connection.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B14E553B008591D7D7BCCBD0960BE9E12F9CC61F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

using CoilGun_PC.View;
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


namespace CoilGun_PC.View {
    
    
    /// <summary>
    /// Serial_connection
    /// </summary>
    public partial class Serial_connection : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\View\Serial_connection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Port_cb;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\Serial_connection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Baud_cb;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\Serial_connection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer Scroll_ser;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\Serial_connection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Serial_text;
        
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
            System.Uri resourceLocater = new System.Uri("/CoilGun_PC;component/view/serial_connection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Serial_connection.xaml"
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
            this.Port_cb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\View\Serial_connection.xaml"
            this.Port_cb.DropDownOpened += new System.EventHandler(this.Port_cb_Open);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\View\Serial_connection.xaml"
            this.Port_cb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.port_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Baud_cb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\View\Serial_connection.xaml"
            this.Baud_cb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.baud_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Scroll_ser = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 4:
            this.Serial_text = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

