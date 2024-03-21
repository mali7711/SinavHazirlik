using Microsoft.AspNetCore.Mvc;
using SinavHazirlik.Models;

namespace SinavHazirlik.Controllers
{

    public class UsersController : Controller
    {
        static List<UsersModel> liste = new List<UsersModel>();

        [HttpGet]
        public IActionResult Ekle(UsersModel kullanici)
        {
            liste.Add(kullanici);
            //return RedirectToAction("Ekle");
            return View();
        }
        
        public IActionResult Giris(UsersModel kullanici)
        {
            return View(kullanici);
        }
        public IActionResult Listele()
        {
            return View(liste);
        }
    }
}
