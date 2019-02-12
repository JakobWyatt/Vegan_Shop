using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vegan_Shop;

namespace Vegan_Shop_Test
{
    public class MainPageModelTest : IMainPageModel
    {
        private IFoodDatabase FoodDatabase;

        public MainPageModelTest( IFoodDatabase foodDatabase )
        {
            FoodDatabase = foodDatabase;
        }

        public async Task<List<Food>> QueryFood( String query )
        {
            return FilterFood(await FoodDatabase.GetFoods(), query);
        }

        private List<Food> FilterFood( List<Food> foods, String query)
        {
            return foods.Where( (Food food) =>
            {
                //Non-case sensitive search
                return food.Name.ToLower().Contains( query.ToLower() );
            }).ToList();
        }
    }
}
