namespace Eventify.Models
{
    public class UserCategory
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
