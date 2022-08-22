using MagazineShop.Models;
using System.Collections.Generic;

namespace MagazineShop.ViewModels
{
    public class DataListViewModel
    {
        public IEnumerable<Product> allProducts { get; set; }
        public IEnumerable<User> allUserSettings { get; set; }
    }
}
