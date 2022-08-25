using MagazineShop.Interfaces;
using MagazineShop.Models;
using MagazineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MagazineShop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IProducts products;
        private readonly ShopCart shopCart;
        public List<ShopCartItem> shopCartItem;

        public ShopCartController(IProducts products, ShopCart shopCart)
        {
            this.products = products;
            this.shopCart = shopCart;
        }

        public IActionResult Cart(int id)
        {
            shopCart.listShopItems = shopCart.getShopItems();

            var obj = new ShopCartViewModel
            {
                shopCart = shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = products.AllProducts.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                shopCart.AddToCart(item);
            }
            return RedirectToAction("Cart");
        }
    }
}
