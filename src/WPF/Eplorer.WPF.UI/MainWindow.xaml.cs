﻿using Explorer.Shared.ViewModels;

namespace Eplorer.WPF.UI
{   
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
