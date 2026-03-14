using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Thedreamproperties.Models;
using Thedreamproperties.Repository;

namespace Thedreamproperties.Controllers
{
    public class HomeController : Controller
    {
        private readonly Icontactmessegerepository _contactmessegerepository;

        public HomeController(Icontactmessegerepository contactmessegerepository) 
        {
            _contactmessegerepository = contactmessegerepository;
        } 
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> sendmessege(string name,string email,string subject,string messege)
        {
            //code to sent data into database
            var contactmessege = new Contactmessege
            {
                name = name,
                email = email,
                subject = subject,
                messege = messege


            };
            await _contactmessegerepository.savacontactmessege
             (contactmessege.name,
              contactmessege.email,
              contactmessege.subject,
              contactmessege.messege);

            return Json(new { success = true, responsetext = "Your Messege has been successfully saved" });
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
