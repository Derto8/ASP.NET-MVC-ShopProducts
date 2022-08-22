using MagazineShop.DBContext;
using MagazineShop.Models;
using MagazineShop.Models.Products;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace MagazineShop
{
    public class DBObjects
    {
        public static void Initial(AppDBContext context)
        {
            if (!context.Products.Any())
                context.Products.AddRange(Products.Select(c => c.Value));

            if (!context.Users.Any())
            {
                context.AddRange(
                        new User
                        {
                            Name = "Nikolay",
                            Adress = "Popova 13",
                            Balance = 1500,
                            Spend = 1200
                        }
                    );
            }

            if (!context.TShirts.Any())
            {
                context.AddRange(
                        new TShirt
                        (
                            "YMKASHIX Graffiti",
                            2700,
                            "YMKASHIX",
                            "/img/YMKASHIX Graffiti.png"
                        ),
                        new TShirt(
                            "HOOK «Вагон»",
                            1900,
                            "HOOK",
                            "/img/HOOK «Вагон».png"
                            ),
                        new TShirt(
                            "BREATH OUT BRTH x OS.ACHSE",
                            2500,
                            "BREATH OUT",
                            "/img/BREATH OUT BRTH x OS.ACHSE.png"
                            )
                    );
            }

            if (!context.Candies.Any())
            {
                context.AddRange(
                        new Candies
                        (
                        "Кофета1",
                        500,
                        "Произоводитель",
                        "/img/Molotov.png"
                        )
                        {
                            Candy = "Конфета",
                        }
                    );
            }

            //if (!context.Milk.Any())
            //{
            //    context.AddRange(
            //            new Milk
            //            (
            //            "Молоко",
            //            100,
            //            "Произоводитель",
            //            "/img/Molotov.png"
            //            )
            //            {
            //                MilkName = "Молоко",
            //            }
            //        );
            //}

            context.SaveChanges();
        }

        private static Dictionary<string, Product> product;
        public static Dictionary<string, Product> Products
        {
            get
            {
                if (product == null)
                {
                    var list = new List<Product>
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

                    product = new Dictionary<string, Product>();
                    foreach (Product element in list)
                        product.Add(element.Name, element);
                }
                return product;
            }
        }
    }
}
