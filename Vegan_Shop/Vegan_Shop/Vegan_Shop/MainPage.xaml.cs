namespace Vegan_Shop
{
    public partial class MainPage : Xamarin.Forms.ContentPage, System.ComponentModel.INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public System.Windows.Input.ICommand WeirdOnSearch
        {
            get
            {
                return new Xamarin.Forms.Command<System.Object>((Sender) => {
                    //OnSearch(Sender, null);
                    coolLabel.Text = "Searched";
                });
            }
        }

        void OnPress(System.Object Sender, System.EventArgs eventArgs)
        {
            coolLabel.Text = "yew";
        }
    }
}
