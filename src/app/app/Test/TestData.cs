using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Vegan_Shop;

namespace Vegan_Shop_Test
{
    public static class TestData
    {
        public static readonly List<Food> TestFood = new List<Food>() {
            new Food( 1, "Cheese and Milk", 3, ImageSource.FromFile( "milk_and_cheese" ) ),
            new Food( 2, "Cheese", 2, ImageSource.FromFile( "cheese" ) ),
            new Food( 3, "Milk", 1, ImageSource.FromFile( "milk" ) )
        };
    }
}
