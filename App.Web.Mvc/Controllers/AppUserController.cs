using App.Web.Mvc.Models.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AppUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index() => View(_userManager.Users);
    }
}
