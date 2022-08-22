using System.ComponentModel.DataAnnotations.Schema;

namespace MagazineShop.Models.Products
{
    [Table("Milk")]
    public class Milk : Product
    {
        public string MilkName { get; set; }
        public Milk(string name, double price, string manufacturer, string img)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Img = img;
        }
    }
}
