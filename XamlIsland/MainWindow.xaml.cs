﻿using System.Windows;
using System.Windows.Controls;
using Microsoft.Toolkit.Wpf.UI.XamlHost;


namespace XamlIsland
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myXamlHost.InitialTypeName = "MainPage";

        }
    }
}
