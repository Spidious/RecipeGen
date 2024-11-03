﻿#pragma checksum "..\..\..\MainContent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79AFA7156714AAD0AE6E49BD80C325DE3C22046D"
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
    /// MainContent
    /// </summary>
    public partial class MainContent : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 48 "..\..\..\MainContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchRecipeTextBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\MainContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddRecipeButton;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\MainContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RecipeData;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\MainContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchPantryTextBox;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\MainContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPantryItemButton;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\MainContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PantryData;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\MainContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchIngredientsTextBox;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\MainContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddIngredientButton;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\MainContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox IngredientsListPlaceholder;
        
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
            System.Uri resourceLocater = new System.Uri("/RecipeGen;component/maincontent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainContent.xaml"
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
            
            #line 27 "..\..\..\MainContent.xaml"
            ((System.Windows.Controls.TabControl)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TabControl_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchRecipeTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\MainContent.xaml"
            this.SearchRecipeTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.Recipe_KeyDown);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\MainContent.xaml"
            this.SearchRecipeTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.SearchRecipeTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\MainContent.xaml"
            this.SearchRecipeTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.SearchRecipeTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddRecipeButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\MainContent.xaml"
            this.AddRecipeButton.Click += new System.Windows.RoutedEventHandler(this.AddRecipeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RecipeData = ((System.Windows.Controls.ListBox)(target));
            
            #line 63 "..\..\..\MainContent.xaml"
            this.RecipeData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RecipeData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SearchPantryTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 111 "..\..\..\MainContent.xaml"
            this.SearchPantryTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.Pantry_KeyDown);
            
            #line default
            #line hidden
            
            #line 112 "..\..\..\MainContent.xaml"
            this.SearchPantryTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.SearchPantryTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 113 "..\..\..\MainContent.xaml"
            this.SearchPantryTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.SearchPantryTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddPantryItemButton = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\..\MainContent.xaml"
            this.AddPantryItemButton.Click += new System.Windows.RoutedEventHandler(this.AddPantryItemButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PantryData = ((System.Windows.Controls.ListBox)(target));
            
            #line 130 "..\..\..\MainContent.xaml"
            this.PantryData.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PantryData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SearchIngredientsTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 158 "..\..\..\MainContent.xaml"
            this.SearchIngredientsTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.Ingredients_KeyDown);
            
            #line default
            #line hidden
            
            #line 159 "..\..\..\MainContent.xaml"
            this.SearchIngredientsTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.SearchIngredientsTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 160 "..\..\..\MainContent.xaml"
            this.SearchIngredientsTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.SearchIngredientsTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AddIngredientButton = ((System.Windows.Controls.Button)(target));
            
            #line 167 "..\..\..\MainContent.xaml"
            this.AddIngredientButton.Click += new System.Windows.RoutedEventHandler(this.AddIngredientButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.IngredientsListPlaceholder = ((System.Windows.Controls.ListBox)(target));
            
            #line 175 "..\..\..\MainContent.xaml"
            this.IngredientsListPlaceholder.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.IngredientsListPlaceholder_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 73 "..\..\..\MainContent.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.RecipeItem_MouseDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

