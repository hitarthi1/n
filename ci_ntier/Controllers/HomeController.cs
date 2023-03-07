using CI.Repo.IRepo;
using ci_ntier.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ci_ntier.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUser _User;

        public HomeController(IUser User)
        {
            _User = User;;
        }



        public IActionResult Index()
        {

            var listofuser=_User.GetUserData();
            return View(listofuser);
        }
        public IActionResult Index2()
        {

          
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}