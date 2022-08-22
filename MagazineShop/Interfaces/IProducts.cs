using MagazineShop.Models;
using MagazineShop.Models.Products;
using System.Collections.Generic;

namespace MagazineShop.Interfaces
{
    public interface IProducts
    {
        IEnumerable<Product> AllProducts { get; }
        //IEnumerable<Milk> AllMilk { get; }
        IEnumerable<Candies> AllCandies { get; }
        IEnumerable<TShirt> AllTShirts { get; }
    }
}
