using MagazineShop.Interfaces;
using MagazineShop.Models;
using MagazineShop.Models.Products;
using System.Collections.Generic;

namespace MagazineShop.Mocks
{
    public class MockProducts : IProducts
    {
        public IEnumerable<Product> AllProducts
        {
            get
            {
                return new List<Product>
                {
                    new TShirt(
                        "Molotov TShirt",
                        1200,
                        "Molotov",
                        "/img/Molotov.png"
                        ),
                    //new Milk(
                    //    "Milk",
                    //    100,
                    //    "Домик в деревне",
                    //    "/img/Milk.png"
                    //    ),
                    new Candies(
                        "Мармелад",
                        300,
                        "Бон-Пари",
                        "/img/Candies.png"
                        )
                };
            }
            set { }
        }

        //public IEnumerable<Milk> AllMilk => throw new System.NotImplementedException();

        public IEnumerable<Candies> AllCandies => throw new System.NotImplementedException();

        public IEnumerable<TShirt> AllTShirts => throw new System.NotImplementedException();
    }
}
