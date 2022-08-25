using MagazineShop.DBContext;
using MagazineShop.Interfaces;
using MagazineShop.Models;
using MagazineShop.Models.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MagazineShop.Repository
{
    public class ProductRepository : IProducts, ICreateProduct
    {
        private readonly AppDBContext appDBContext;

        public ProductRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }
        public IEnumerable<Product> AllProducts => appDBContext.Products;

        public void CreateProduct(AddProduct addProduct)
        {
            Product product = new Product();
            if (addProduct.Class == "TShirt")
            {
                product = new TShirt
                (
                    addProduct.Name,
                    addProduct.Price,
                    addProduct.Manufacturer,
                    addProduct.Img
                );
                appDBContext.Products.Add(product);
            }
            if(addProduct.Class == "Candy")
            {
                product = new Candies
                (
                    addProduct.Name,
                    addProduct.Price,
                    addProduct.Manufacturer,
                    addProduct.Img
                );
                appDBContext.Products.Add(product);
            }
            appDBContext.SaveChanges();
        }
    }
}
