using MagazineShop.Interfaces;
using MagazineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MagazineShop.Controllers
{
    public class UserController : Controller
    {
        public readonly IUserSettings iUserSettings;

        public UserController(IUserSettings iUserSettings)
        {
            this.iUserSettings = iUserSettings;
        }

        public IActionResult ViewUserSettings()
        {
            DataListViewModel obj = new DataListViewModel();
            obj.allUserSettings = iUserSettings.UserSettings;
            return View(obj);
        }
    }
}
