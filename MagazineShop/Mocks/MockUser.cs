using MagazineShop.Interfaces;
using MagazineShop.Models;
using System.Collections.Generic;

namespace MagazineShop.Mocks
{
    public class MockUser : IUserSettings
    {
        public IEnumerable<User> UserSettings
        {
            get
            {
                return new List<User>
                {
                    new User{
                        Id = 1,
                        Name = "Nikolay",
                        Adress = "Gazety Zvezda",
                        Balance = 1500,
                        Spend = 1200
                    }
                };
            }
            set { }
        }
    }
}
