using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.Generic;
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
                    //Query the foods from our model, then set the foodlist to these new foods.
                    mainPageModel.QueryFood( sender.ToString() ).ContinueWith( (Task<List<Food>> foodQuery) =>
                    {
                        FoodList = new ObservableCollection<Food>(foodQuery.Result);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FoodList"));
                    });
                }));
            }
        }

        public ObservableCollection<Food> FoodList { get; private set; } = new ObservableCollection<Food>();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
