using MagazineShop.DBContext;
using MagazineShop.Interfaces;
using MagazineShop.Models;
using MagazineShop.Models.Products;
using System.Collections.Generic;

namespace MagazineShop.Repository
{
    public class ProductRepository : IProducts
    {
        private readonly AppDBContext appDBContext;

        public ProductRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }
        public IEnumerable<Product> AllProducts => appDBContext.Products;
        public IEnumerable<Candies> AllCandies => appDBContext.Candies;
        //public IEnumerable<Milk> AllMilk => appDBContext.Milk;
        public IEnumerable<TShirt> AllTShirts => appDBContext.TShirts;
    }
}
