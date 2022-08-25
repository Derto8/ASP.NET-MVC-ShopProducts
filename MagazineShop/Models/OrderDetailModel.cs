namespace MagazineShop.Models
{
    public class OrderDetailModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public virtual Product Product { get; set; }
        public virtual OrderModel Order { get; set; }
    }
}
