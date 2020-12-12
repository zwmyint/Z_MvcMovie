using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET /HelloWorld/
        /* public string Index()
        {
            return "This is my default action ...";
        } */

        public IActionResult Index()
        {
            return View();
        }

        // GET /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int numTimes = 1)
        //public string Welcome(string name, int ID = 1)
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
            //https://localhost:{PORT}/HelloWorld/Welcome/3?name=Rick
            //https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
            //return "This is the welcome action method ...";
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is {numTimes}");
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();

            
        }



        //
    }
}