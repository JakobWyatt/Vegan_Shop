using System;
using System.ComponentModel;

namespace Vegan_Shop
{
    //ViewModel implements IMainPageViewModel for view binding
    public class MainPageViewModel : INotifyPropertyChanged
    {
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

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
