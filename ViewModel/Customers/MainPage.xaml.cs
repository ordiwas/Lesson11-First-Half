using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Customers
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            List<string> titles = new List<string>
            {
                "Mr", "Mrs", "Ms", "Miss"
            };
            this.title.ItemsSource = titles;
            this.cTitle.ItemsSource = titles;

            ViewModel viewModel = new ViewModel();
            this.DataContext = viewModel;
        }
    }
}
