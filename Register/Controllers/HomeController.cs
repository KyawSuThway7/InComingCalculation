using Microsoft.AspNetCore.Mvc;
using Register.Models;

namespace Register.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        [HttpPost]
        public IActionResult Index(RegisterView register)
        {
            ViewBag.Restlt = $"Your register is successfully completed,Your Email is {register.Email}";
            ViewBag.Name = register.Name;
            ViewBag.Email = register.Email;
            ViewBag.Password = register.Password;
            ViewBag.ConfirmPassword = register.ConfirmPassword;
            ViewBag.DateBirth = register.Date;
            ViewBag.City = register.City;
            ViewBag.Adress = register.Adress;
      
            return View();
        }
        
    }
}
