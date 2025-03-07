using CV.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            //so if the user goes back they dont have a random error message
            ViewData["ErrorMessage"] = "";
            return View();
        }
        public IActionResult Skills()
        {
            return View();
        }
        public IActionResult Education()
        {
            return View();
        }
        public IActionResult ContactInput(String Name, String Company, String EmailAddress, String PhoneNumber, String Subject, String Message )
        {
            String error = "";
            if (!(Name is String))
            {
                error = "Name is required";
            }
             else if (Name.Length > 15)
            {
                error = "Name is to long, max chacrter is 15";
            }
            else if (!(EmailAddress is String))
            {
                error = "Email is required";
            } else if (EmailAddress.Length > 70) 
            {

            }
            else if (!(PhoneNumber is int))
            {
                error = "Phone number is required and must be only numbers";
            }
            else if (PhoneNumber.Length < 9)
            {
                error = "Phone number is to short";
            }
            else if (PhoneNumber.Length > 10 )
            {
                error = "Phone number is to long";
            }
            else if (!(Subject is String))
            {
                error = "Subject is required";
            }
            else if (Subject.Length > 50)
            {
                error = "Max subject length is 50 chracters";
            }
            else  if (!(Message is String))
            {
                error = "Message is required";
            }
            else if (Message.Length >= 100)
            {
                error = "Max message length is 200 charcters";
            } else if (!(Company is null) && Company.Length > 50)
            {
                error = "max input for company is 50 characters";
            }


            ViewData["ErrorMessage"] = error;
            return View("Contact");
            
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
