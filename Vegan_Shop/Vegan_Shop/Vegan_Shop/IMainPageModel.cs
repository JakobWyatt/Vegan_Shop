using System;
using System.ComponentModel;

namespace Vegan_Shop
{
    public interface IMainPageModel : INotifyPropertyChanged
    {
        String TextBox { get; set; }
        void Count();
    }
}
