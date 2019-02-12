using System;
using SQLite;
using Xamarin.Forms;

namespace Vegan_Shop
{
    [Table("Food")]
    public class Food
    {
        [PrimaryKey]
        public int _id { get; set; }

        public String Name { get; set; }

        public Decimal Price { get; set; }

        [Ignore]
        public ImageSource Image { get; set; }

        public Food(int id, String name, Decimal price, ImageSource image)
        {
            _id = id;
            Name = name;
            Price = price;
            Image = image;
        }

        //required for SQLite Database
        public Food() { }
    }
}
