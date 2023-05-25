using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
