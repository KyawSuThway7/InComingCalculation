using Microsoft.AspNetCore.Mvc;

namespace Currency.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string selectCurrencyV1, string selectCurrencyV2, decimal amount)
        {
            List<string> errors = new();
            if (string.IsNullOrEmpty(selectCurrencyV1))
            {
                errors.Add("Need to chose currency form Text-1");
            }
            if (string.IsNullOrEmpty(selectCurrencyV2))
            {
                errors.Add("Need to chose currency form Text-2");
            }
            if (amount <= 0)
            {
                errors.Add("Input must be Positive number or greather than Zero");
            }
            if (errors.Count > 0)
            {
                ViewBag.Errors = errors;
                return View();
            }

            string result = "";
            switch (selectCurrencyV1)
            {
                case "1": result = "1"; break;//Us
                case "2": result = "2"; break;//Sg
                case "3": result = "3"; break;//Th
                case "4": result = "4"; break;//My
            }
            string resultOne = "";
            switch (selectCurrencyV2)
            {
                case "1": resultOne = "1"; break;//Us
                case "2": resultOne = "2"; break;//Sg
                case "3": resultOne = "3"; break;//Th
                case "4": resultOne = "4"; break;//My
            }
            string currency = result + resultOne;
            decimal ans = 0;
            switch (currency)
            {
                case "11": ans = amount * 1; break;
                case "12": ans = amount / 10; break;
                case "13": ans = amount / 35; break;
                case "14": ans = amount / 1600; break;

                case "21": ans = amount * 10; break;
                case "22": ans = amount * 1; break;
                case "23": ans = amount / 25; break;
                case "24": ans = amount / 1500; break;

                case "31": ans = amount * 35; break;
                case "32": ans = amount * 25; break;
                case "33": ans = amount * 1; break;
                case "34": ans = amount / 1000; break;

                case "41": ans = amount * 1600; break;
                case "42": ans = amount * 1500; break;
                case "43": ans = amount * 1000; break;
                case "44": ans = amount * 1; break;

            }
            ViewBag.SelectShowOne = selectCurrencyV1;
            ViewBag.SelectShowTwo = selectCurrencyV2;
            ViewBag.amountShow = amount;
            ViewBag.Ans = ans;
            return View();
        }
    }
}
