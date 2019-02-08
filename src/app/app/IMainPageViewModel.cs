using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Vegan_Shop
{
    public interface IMainPageViewModel : INotifyPropertyChanged
    {
        ICommand SearchFood { get; }
        ObservableCollection<Food> FoodList { get; }
    }
}
