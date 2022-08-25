using MagazineShop.Controllers;
using MagazineShop.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MagazineShop.Models
{
    public class ShopCart
    {
        private readonly AppDBContext appDBContext;
        public ShopCartController shopCartController;
        public string ShopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }

        public ShopCart(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var content = services.GetService<AppDBContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            
            session.SetString("CartId", shopCartId);
            return new ShopCart(content) { ShopCartId = shopCartId };
        }

        public void AddToCart(Product product)
        {
            appDBContext.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Product = product,
                Price = product.Price
            });

            appDBContext.SaveChanges();
        }

        public List<ShopCartItem> getShopItems()
        {
            return appDBContext.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.Product).ToList();
        }
    }
}
