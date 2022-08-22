namespace MagazineShop.Models
{
    public class ShopProductItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Price { get; set; }
        public string ShowProductId { get; set; }
    }
}
