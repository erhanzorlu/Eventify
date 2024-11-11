namespace Eventify.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Event> Events { get; set; } // Bir kategoride birden fazla etkinlik olabilir
    }
}
