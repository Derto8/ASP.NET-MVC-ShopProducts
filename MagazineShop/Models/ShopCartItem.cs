namespace MagazineShop.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }
        public string ShopCartId { get; set; }
    }
}
