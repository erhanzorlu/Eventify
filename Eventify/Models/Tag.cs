namespace Eventify.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public List<EventTag> EventTags { get; set; } // Bir etiket birden fazla etkinlikle ilişkili olabilir
        public List<UserTag> UserTags { get; set; }
    }
}
