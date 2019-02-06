using Xamarin.Forms;
using System;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Vegan_Shop
{
    public partial class MainPage : ContentPage
    {
        private IMainPageViewModel viewModel;
        
        public MainPage( IMainPageViewModel inViewModel )
        {
            InitializeComponent();
            viewModel = inViewModel;
            this.BindingContext = viewModel;
        }
    }
}
