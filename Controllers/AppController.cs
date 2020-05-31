using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Services;
using NetCoreApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {

            if(ModelState.IsValid)
            {
                //Send Email
                _mailService.SendMessage("dmytrocontact@gmail.com", model.Subject, $"From: {model.Name} / {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
             }
            else
            {
                //Show errors
            }

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About";

            return View();
        }
    }

    
}
