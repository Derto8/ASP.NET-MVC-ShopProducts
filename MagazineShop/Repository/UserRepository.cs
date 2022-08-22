using MagazineShop.DBContext;
using MagazineShop.Interfaces;
using MagazineShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MagazineShop.Repository
{
    public class UserRepository : IUserSettings
    {
        private readonly AppDBContext appDBContext;

        public UserRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<User> UserSettings => appDBContext.Users;
    }
}
