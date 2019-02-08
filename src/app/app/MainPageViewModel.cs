using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Vegan_Shop
{
    //ViewModel implements IMainPageViewModel for view binding
    public class MainPageViewModel : IMainPageViewModel
    {
        private IMainPageModel mainPageModel;

        public MainPageViewModel( IMainPageModel inMainPageModel )
        {
            mainPageModel = inMainPageModel;
        }

        private ICommand _searchFood;
        public ICommand SearchFood
        {
            get
            {
                return _searchFood ?? (_searchFood = new Command( ( Object sender ) =>
                {
                    //Cannot reassign, as we would lose the binding to FoodList
                    FoodList.Clear();
                    mainPageModel.queryFood( sender.ToString() ).ForEach( FoodList.Add );
                }));
            }
        }

        public ObservableCollection<Food> FoodList { get; } = new ObservableCollection<Food>();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
