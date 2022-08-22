using MagazineShop.Models;
using System.Collections.Generic;

namespace MagazineShop.Interfaces
{
    public interface IUserSettings
    {
        IEnumerable<User> UserSettings { get;}
    }
}
