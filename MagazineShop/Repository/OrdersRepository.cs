using MagazineShop.DBContext;
using MagazineShop.Interfaces;
using MagazineShop.Models;
using System;

namespace MagazineShop.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContext appDBContext;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContext appDBContext, ShopCart shopCart)
        {
            this.appDBContext = appDBContext;
            this.shopCart = shopCart;
        }

        public void CreateOrder(OrderModel order)
        {
            order.OrderTime = DateTime.Now;
            appDBContext.OrderModel.Add(order);

            appDBContext.SaveChanges();

            var items = shopCart.listShopItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetailModel()
                {
                    ProductId = item.Product.Id,
                    OrderId = order.Id,
                    Price = item.Product.Price
                };
                appDBContext.OrderDetailModel.Add(orderDetail);
            }
            appDBContext.SaveChanges();
        }
    }
}

