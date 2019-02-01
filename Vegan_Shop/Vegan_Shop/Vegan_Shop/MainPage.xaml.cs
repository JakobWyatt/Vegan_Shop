using Xamarin.Forms;
using System;
using System.Windows.Input;

namespace Vegan_Shop
{
    public partial class MainPage : Xamarin.Forms.ContentPage
    {
        private IMainPageModel pageModel;

        public MainPage( IMainPageModel inPageModel )
        {
            InitializeComponent();
            pageModel = inPageModel;

            //The SearchBar binding context is the controller
            TopSearchBar.BindingContext = this;
            //We are using an MVC pattern here, so the label's binding context is the model
            MidLabel.BindingContext = pageModel;

            pageModel.TextBox = "Default";
        }

        private ICommand _onSearch;
        public ICommand OnSearch
        {
            get
            {
                return _onSearch ?? (_onSearch = new Command<Object>((Sender) => {
                    pageModel.TextBox = (String)Sender;
                }));
            }
        }

        public void OnPress(Object Sender, EventArgs eventArgs)
        {
            pageModel.Count();
        }
    }
}
