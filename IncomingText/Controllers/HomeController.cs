using IncomingText.Models;
using Microsoft.AspNetCore.Mvc;


namespace IncomingText.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Result = null;
            return View();
        }
        [HttpPost]
        public JsonResult Index(totalAmount ta)
        {
            double result = 0;
            if(ta.amount > 300000)
            {
                result = ta.amount / 100 * 10;
                if(ta.father > 0 )
                {
                    result = result - 50000;
                }
                if(ta.mother > 0)
                {
                    result = result - 50000;
                }
                if(ta.Married > 0)
                {
                    result = result - 30000;
                }
                if(ta.children > 0)
                {
                    result = result - (ta.children * 30000);
                }
            }
            return Json(result);
           
           
        }
    }
}
