﻿

#pragma checksum "C:\Users\Konstantinos\Desktop\epl361.winter16.team3-master\epl361.winter16.team3-master\uOrder\orderManagement.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F0BFBB2EC01C1CCE9E4A1A56B785FD7A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uOrder
{
    partial class orderManagement : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Page pageRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Data.CollectionViewSource itemsViewSource; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid orderGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ColumnDefinition primaryColumn; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid titlePanel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock textBlock; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel menuGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel categoryGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid currOrder; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ScrollViewer allOrdersScroller; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button button; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel allOrdersStack; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ScrollViewer scrollerOrders; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock textBlock1; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button placeOrder; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button removeProduct; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock textBlock2; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock price; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel currOrderStack; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button backButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock pageTitle; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualStateGroup ViewStates; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState PrimaryView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState SinglePane; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState SinglePane_Detail; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///orderManagement.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (global::Windows.UI.Xaml.Controls.Page)this.FindName("pageRoot");
            itemsViewSource = (global::Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("itemsViewSource");
            orderGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("orderGrid");
            primaryColumn = (global::Windows.UI.Xaml.Controls.ColumnDefinition)this.FindName("primaryColumn");
            titlePanel = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("titlePanel");
            textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("textBlock");
            menuGrid = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("menuGrid");
            categoryGrid = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("categoryGrid");
            currOrder = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("currOrder");
            allOrdersScroller = (global::Windows.UI.Xaml.Controls.ScrollViewer)this.FindName("allOrdersScroller");
            button = (global::Windows.UI.Xaml.Controls.Button)this.FindName("button");
            allOrdersStack = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("allOrdersStack");
            scrollerOrders = (global::Windows.UI.Xaml.Controls.ScrollViewer)this.FindName("scrollerOrders");
            textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("textBlock1");
            placeOrder = (global::Windows.UI.Xaml.Controls.Button)this.FindName("placeOrder");
            removeProduct = (global::Windows.UI.Xaml.Controls.Button)this.FindName("removeProduct");
            textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("textBlock2");
            price = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("price");
            currOrderStack = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("currOrderStack");
            backButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("backButton");
            pageTitle = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("pageTitle");
            ViewStates = (global::Windows.UI.Xaml.VisualStateGroup)this.FindName("ViewStates");
            PrimaryView = (global::Windows.UI.Xaml.VisualState)this.FindName("PrimaryView");
            SinglePane = (global::Windows.UI.Xaml.VisualState)this.FindName("SinglePane");
            SinglePane_Detail = (global::Windows.UI.Xaml.VisualState)this.FindName("SinglePane_Detail");
        }
    }
}



