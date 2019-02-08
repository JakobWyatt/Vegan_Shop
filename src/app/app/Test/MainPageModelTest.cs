using System;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;
using Vegan_Shop;

namespace Vegan_Shop_Test
{
    public class MainPageModelTest : IMainPageModel
    {
        public List<Food> queryFood( String query )
        {
            return TestData.TestFood.Where((Food food) =>
            {
                //Non-case sensitive search
                return food.Name.ToLower().Contains( query.ToLower() );
            }).ToList();
        }
    }
}
