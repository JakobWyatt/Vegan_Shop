using System;
using Xamarin.Forms;

namespace Vegan_Shop
{
    public class Food
    {
        public String Name
        {
            get;
        }

        public Decimal Price
        {
            get;
        }

        public ImageSource Image
        {
            get;
        }

        public Food(String name, Decimal price, ImageSource image)
        {
            Name = name;
            Price = price;
            Image = image;
        }
    }
}
