﻿#pragma checksum "..\..\NotePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7CCB17FAC56B6D74AC95DBA38510BA22"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EveryDayNote;
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


namespace EveryDayNote {
    
    
    /// <summary>
    /// NotePage
    /// </summary>
    public partial class NotePage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\NotePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Text;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\NotePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Voice;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\NotePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Video;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\NotePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Picture;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\NotePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Date;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\NotePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel FieldPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/EveryDayNote;component/notepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NotePage.xaml"
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
            
            #line 5 "..\..\NotePage.xaml"
            ((EveryDayNote.NotePage)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 9 "..\..\NotePage.xaml"
            ((EveryDayNote.NotePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Text = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\NotePage.xaml"
            this.Text.Click += new System.Windows.RoutedEventHandler(this.Text_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Voice = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\NotePage.xaml"
            this.Voice.Click += new System.Windows.RoutedEventHandler(this.Voice_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Video = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\NotePage.xaml"
            this.Video.Click += new System.Windows.RoutedEventHandler(this.Video_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Picture = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\NotePage.xaml"
            this.Picture.Click += new System.Windows.RoutedEventHandler(this.Picture_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Date = ((System.Windows.Controls.DatePicker)(target));
            
            #line 24 "..\..\NotePage.xaml"
            this.Date.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Date_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FieldPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

