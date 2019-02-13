using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Vegan_Shop_Test;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Vegan_Shop
{
    public partial class App : Application
    {
        private FakeFoodDatabase FoodDatabase { get; set; } = new FakeFoodDatabase();

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage(new MainPageViewModel(new MainPageModelTest(FoodDatabase)));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            FoodDatabase.Update();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
