﻿#pragma checksum "..\..\..\AddMovieWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86AAE16C9148FB3EBDEAE904A9648151CFB055D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FilmDB;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace FilmDB {
    
    
    /// <summary>
    /// AddMovieWindow
    /// </summary>
    public partial class AddMovieWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\AddMovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MovieTitle;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\AddMovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MovieActors;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\AddMovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox GenresListBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\AddMovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MovieDirector;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\AddMovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MovieReleaseYear;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\AddMovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MovieDuration;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\AddMovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MovieImagePath;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\AddMovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MovieImage;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\AddMovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FilmDB.RatingControl MovieRatingControl;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\AddMovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanelModalButtons;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\AddMovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanelNoneModalButtons;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FilmDB;component/addmoviewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddMovieWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MovieTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.MovieActors = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.GenresListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.MovieDirector = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.MovieReleaseYear = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.MovieDuration = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.MovieImagePath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.MovieImage = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            
            #line 38 "..\..\..\AddMovieWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BrowseImage_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MovieRatingControl = ((FilmDB.RatingControl)(target));
            return;
            case 11:
            this.StackPanelModalButtons = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 12:
            
            #line 45 "..\..\..\AddMovieWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Ok_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.StackPanelNoneModalButtons = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 14:
            
            #line 49 "..\..\..\AddMovieWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 50 "..\..\..\AddMovieWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

