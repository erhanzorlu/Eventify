using Eventify.Models;

namespace Eventify.Services
{
    public class EventService
    {
        private readonly AppDbContext _context;

        public EventService(AppDbContext context)
        {
            _context = context;
        }

        public Event FindNearestEvent(double userLat, double userLon)
        {
            var allEvents = GetEvents();

            var nearestEvent = allEvents
                .Select(e => new
                {
                    Event = e,
                    Distance = GeoCalculator.CalculateDistance(userLat, userLon, e.Latitude, e.Longitude)
                })
                .OrderBy(e => e.Distance) // Mesafeye göre sırala
                .FirstOrDefault(); // En yakını seç

            return nearestEvent?.Event;
        }

        public List<Event> GetEvents()
        {
            return _context.Events.ToList();
        }

        public Event GetEventById(int id)
        {
            return _context.Events.FirstOrDefault(e => e.EventId == id);
        }

        public void AddEvent(Event newEvent)
        {
            _context.Events.Add(newEvent);
            _context.SaveChanges();
        }

        public void UpdateEvent(Event updatedEvent)
        {
            _context.Events.Update(updatedEvent);
            _context.SaveChanges();
        }

        public void DeleteEvent(int id)
        {
            var eventToDelete = _context.Events.FirstOrDefault(e => e.EventId == id);
            _context.Events.Remove(eventToDelete);
            _context.SaveChanges();
        }

        public List<Event> GetEventsByUserId(Guid userId)
        {
            return _context.UserEvents
                .Where(ue => ue.UserId == userId)
                .Select(ue => ue.Event)
                .ToList();
        }

        public void AddUserToEvent(Guid userId, int eventId)
        {
            var userEvent = new UserEvent
            {
                UserId = userId,
                EventId = eventId
            };

            _context.UserEvents.Add(userEvent);
            _context.SaveChanges();
        }

        public void RemoveUserFromEvent(Guid userId, int eventId)
        {
            var userEvent = _context.UserEvents.FirstOrDefault(ue => ue.UserId == userId && ue.EventId == eventId);
            _context.UserEvents.Remove(userEvent);
            _context.SaveChanges();
        }
    }
}
