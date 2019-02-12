using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Vegan_Shop;

namespace Vegan_Shop_Test
{
    public static class TestData
    {
        public static readonly List<Food> TestFood = new List<Food>() {
            new Food( 1, "Cheese and Milk", 3, ImageSource.FromUri( new Uri("https://static.standard.co.uk/s3fs-public/thumbnails/image/2018/09/12/10/milkcheese1209a.jpg?w968") ) ),
            new Food( 2, "Cheese", 2, ImageSource.FromUri( new Uri("https://static1.squarespace.com/static/5a1592ff0abd04e470d48744/t/5a27bbeeec212d905273a14c/1512996237223/Kaas.jpeg?format=1500w") ) ),
            new Food( 3, "Milk", 1, ImageSource.FromUri( new Uri("https://img.taste.com.au/5VamxIAS/taste/2016/11/almond-milk-109280-1.jpeg") ) ),
        };
    }
}
