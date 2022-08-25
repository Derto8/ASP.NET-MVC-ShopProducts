using MagazineShop.Interfaces;
using MagazineShop.Models;
using MagazineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MagazineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProducts iProducts;
        private readonly IUserSettings iUserSettings;
        private readonly ICreateProduct iCreateProduct;

        public ProductController(IProducts iProducts, IUserSettings iUserSettings, ICreateProduct iCreateProduct)
        {
            this.iProducts = iProducts;
            this.iUserSettings = iUserSettings;
            this.iCreateProduct = iCreateProduct;
        }

        public IActionResult ViewProducts()
        {
            DataListViewModel obj = new DataListViewModel();
            obj.allProducts = iProducts.AllProducts;
            obj.allUserSettings = iUserSettings.UserSettings;
            return View(obj);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(AddProduct addProduct)
        {
            if (ModelState.IsValid)
            {
                iCreateProduct.CreateProduct(addProduct);
                return RedirectToAction("AddedProduct");
            }
            return View(addProduct);
        }

        public IActionResult AddedProduct()
        {
            return View();
        }
    }
}
