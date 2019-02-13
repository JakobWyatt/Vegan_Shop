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
        public ImageSource Image {
            get
            {
                return ImageSource.FromFile( "image_" + _id.ToString() );
            }
        }

        public Food(int id, String name, Decimal price)
        {
            _id = id;
            Name = name;
            Price = price;
        }

        //required for SQLite Database
        public Food() { }
    }
}
