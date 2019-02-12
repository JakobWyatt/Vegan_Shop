using Xamarin.Forms;

namespace Vegan_Shop
{
    public partial class MainPage : ContentPage
    {
        private IMainPageViewModel viewModel;
        
        public MainPage( IMainPageViewModel inViewModel )
        {
            InitializeComponent();
            viewModel = inViewModel;
            BindingContext = viewModel;
        }
    }
}
