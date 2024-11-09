using Eventify.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Eventify.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

      

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                user.UserId = Guid.NewGuid();
                user.CreatedAt = DateTime.UtcNow;

                _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToAction("Privacy", "Home");
            }

            return View(user);
        }
        public IActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEvent(Event newEvent)
        {
            if (ModelState.IsValid)
            {
                newEvent.EventId = Guid.NewGuid();

                _context.Events.Add(newEvent);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(newEvent);
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
