using CV.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IValidation _validation;
        private MessageContext _context;

        public HomeController(ILogger<HomeController> logger, IValidation validation, MessageContext context )
        {
            _logger = logger;
            _validation = validation;
            _context = context;
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
        public IActionResult ContactInput(String Name, String? Company, String EmailAddress, String PhoneNumber, String Subject, String Message )
        {
            String error = "";
            string checker = "";

            checker = _validation.validateManditoryString(Name);
            if(!checker.Equals(""))
            {
                error = error + checker +  " for name, ";
            }
            
                checker = _validation.validateOptionalString(Company);
            
            
            
            if (!checker.Equals(""))
            {
                error = error + checker + " for Company, ";
            }


            checker = _validation.validateManditoryString(EmailAddress);
            if (!checker.Equals(""))
            {
                error = error + checker + " for email, ";
            }

            checker = _validation.validatePhoneNumber(PhoneNumber);
            if (!checker.Equals(""))
            {
                error = error + checker + " for phone number, ";
            }

            checker = _validation.validateManditoryString(Subject);
            if (!checker.Equals(""))
            {
                error = error + checker + " for subject, ";
            }

            checker = _validation.validateManditoryString(Message);
            if (!checker.Equals(""))
            {
                error = error + checker + " for message, ";
            }

            if (error.Equals(""))
            {
                Message toBeSaved = new Message() { Name = Name, Company = Company, Email = EmailAddress, PhoneNumber = PhoneNumber, Subject = Subject, UserMessage = Message };


                _context.Add(toBeSaved);
                _context.SaveChanges();
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
