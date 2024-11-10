using Eventify.Models;
using Eventify.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Eventify.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly EventService _eventService;

        public HomeController(AppDbContext context, EventService eventService)
        {
            _context = context;
            _eventService = eventService;
        }

        public IActionResult Index()
        {
            return View();
        }

      

        [HttpPost]
        public IActionResult Index(User user)
        {
         
                user.UserId = Guid.NewGuid();
                user.CreatedAt = DateTime.UtcNow;
                user.Gender = Models.Enums.Gender.Male;
            user.PasswordHash = "BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);";

            _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToAction("Privacy", "Home");

        }
        public IActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEvent(Event newEvent)
        {
           
                newEvent.EventId = Guid.NewGuid();

            _context.Events.Add(newEvent);
                _context.SaveChanges();

            return View(newEvent);
            

        }

        public IActionResult FindNearestEvent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FindNearestEvent(double latitude, double longitude)
        {
            if (latitude == 0 || longitude == 0)
            {
                ViewBag.Message = "Geçersiz konum bilgisi.";
                return View();
            }

            var nearestEvent = _eventService.FindNearestEvent(latitude, longitude);

            if (nearestEvent != null)
            {
                ViewBag.NearestEvent = new
                {
                    nearestEvent.Name,
                    nearestEvent.Location,
                    Distance = Math.Round(GeoCalculator.CalculateDistance(latitude, longitude, nearestEvent.Latitude, nearestEvent.Longitude), 2)
                };
            }
            else
            {
                ViewBag.Message = "En yakýn etkinlik bulunamadý.";
            }

            return View();
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
