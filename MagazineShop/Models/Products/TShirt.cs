using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MagazineShop.Models.Products
{
    [Table("TShirts")]
    public class TShirt : Product
    {
        public string TShirtName { get; set; }
        public string TShirtDescription { get; set; }
        public TShirt(string name, double price, string manufacturer, string img)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Img = img;
        }

        public override double GetDiscountPrice(Product product)
        {
            double onePercent = Price / 100;
            double sale = onePercent * 20;
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
