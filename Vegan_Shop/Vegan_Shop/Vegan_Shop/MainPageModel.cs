using System;
using System.ComponentModel;

namespace Vegan_Shop
{
    public class MainPageModel : IMainPageModel
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

        private int _count = 0;
        private int _Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                TextBox = _count.ToString();
            }
        }

        public void Count()
        {
            ++_Count;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
