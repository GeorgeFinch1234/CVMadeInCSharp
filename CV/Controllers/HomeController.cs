using CV.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IValidation _validation;

        public HomeController(ILogger<HomeController> logger, IValidation validation)
        {
            _logger = logger;
            _validation = validation;
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

            error = _validation.validateManditoryString(Name);
            error = _validation.validateOptionalString(Company);
            error = _validation.validateManditoryString(EmailAddress);
            error = _validation.validatePhoneNumber(PhoneNumber);
            error = _validation.validateManditoryString(Subject);
            error = _validation.validateManditoryString(Message);

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
