using MagazineShop.Interfaces;
using MagazineShop.Models;
using MagazineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MagazineShop.Controllers
{
    public class ProductController : Controller
    {
        public readonly IProducts iProducts;
        public readonly IUserSettings iUserSettings;

        public ProductController(IProducts iProducts, IUserSettings iUserSettings)
        {
            this.iProducts = iProducts;
            this.iUserSettings = iUserSettings;
        }

        public IActionResult ViewProducts()
        {
            DataListViewModel obj = new DataListViewModel();
            obj.allProducts = iProducts.AllProducts;
            obj.allUserSettings = iUserSettings.UserSettings;
            return View(obj);
        }

        [HttpPost]
        public IActionResult AddProduct(AddProduct addProduct)
        {
            return View(addProduct);
        }
    }
}
