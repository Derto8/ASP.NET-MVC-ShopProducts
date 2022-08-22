using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagazineShop.Models.Products
{
    [Table("Candies")]
    public class Candies : Product
    {
        public string Candy { get; set; }
        public Candies(string name, double price, string manufacturer, string img)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Img = img;
        }

        public override double GetDiscountPrice(Product product)
        {
            double onePersent = Price / 100;
            double sale = onePersent * 10;
            Price -= sale;
            return Price;
        }

        public override double GetSale(Product product)
        {
            double Price = this.Price;
            double price = GetDiscountPrice(product);
            double percents = Math.Round(100 - ((price / Price) * 100));
            return percents;
        }
    }
}
