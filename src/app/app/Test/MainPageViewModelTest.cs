using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Vegan_Shop;

namespace Vegan_Shop_Test
{
    public class MainPageViewModelTest : IMainPageViewModel
    {
        private ICommand _searchFood;
        public ICommand SearchFood
        {
            get
            {
                return _searchFood ?? (_searchFood = new Command((Object sender) => {}));
            }
        }

        public ObservableCollection<Food> FoodList { get; } = new ObservableCollection<Food>(TestData.TestFood);

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
