using MagazineShop.Models.Products;

namespace MagazineShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Img { get; set; }

        public virtual double GetDiscountPrice(Product product)
        {
            return Price;
        }

        public virtual double GetSale(Product product)
        {
            return 0;
        }
    }
}
