namespace Eventify.Models
{
    public class UserEvent
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public DateTime RegisteredDate { get; set; } // Kullanıcının katıldığı tarih
    }
}
