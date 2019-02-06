using System;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Vegan_Shop
{
    //ViewModel implements IMainPageViewModel for view binding
    public class MainPageViewModel : IMainPageViewModel
    {
        /*
        private String _textBox;
        public String TextBox
        {
            get
            {
                return _textBox;
            }
            set
            {
                if ( _textBox != value )
                {
                    _textBox = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TextBox"));
                }
            }
        }
        */
        public ObservableCollection<String> ItemList = new ObservableCollection<String>();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
