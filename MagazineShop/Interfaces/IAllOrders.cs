using MagazineShop.Models;

namespace MagazineShop.Interfaces
{
    public interface IAllOrders
    {
        void CreateOrder(OrderModel order);
    }
}
