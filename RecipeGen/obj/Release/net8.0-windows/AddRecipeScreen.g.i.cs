﻿#pragma checksum "..\..\..\AddRecipeScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C9A09B1A9112ED206FA43437715998CFD7E570B3"
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


namespace RecipeGen {
    
    
    /// <summary>
    /// AddRecipeScreen
    /// </summary>
    public partial class AddRecipeScreen : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\AddRecipeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RecipeTitleTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\AddRecipeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RecipeURLTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\AddRecipeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RecipeIngredientsTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RecipeGen;component/addrecipescreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddRecipeScreen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RecipeTitleTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\AddRecipeScreen.xaml"
            this.RecipeTitleTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RecipeTitleTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\AddRecipeScreen.xaml"
            this.RecipeTitleTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.RecipeTitleTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RecipeURLTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\AddRecipeScreen.xaml"
            this.RecipeURLTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RecipeURLTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\AddRecipeScreen.xaml"
            this.RecipeURLTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.RecipeURLTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RecipeIngredientsTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\AddRecipeScreen.xaml"
            this.RecipeIngredientsTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RecipeIngredientsTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\AddRecipeScreen.xaml"
            this.RecipeIngredientsTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.RecipeIngredientsTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 33 "..\..\..\AddRecipeScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddRecipeButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 37 "..\..\..\AddRecipeScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
