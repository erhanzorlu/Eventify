using Eventify.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventify.Mappings
{
    public class EventMap : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasData(
                new Event
                {
                    EventId = 1,
                    Name = "Fatih",
                    StartDate = new DateTime(2024, 11, 12, 9, 0, 0),
                    EndDate = new DateTime(2024, 11, 12, 17, 0, 0),
                    Location = "Fatih",
                    City = "İstanbul",
                    District = "Fatih",
                    CategoryId = 1,
                    MaxParticipants = 24,
                    Description = "açıklama",
                    Latitude = 4100922481235155,
                    Longitude = 28969144821166996

                },
                new Event
                {
                    EventId = 2,
                    Name = "Kadıköy",
                    StartDate = new DateTime(2024, 11, 13, 10, 0, 0),
                    EndDate = new DateTime(2024, 11, 13, 18, 0, 0),
                    Location = "Kadıköy",
                    City = "İstanbul",
                    District = "Kadıköy",
                    CategoryId = 2,
                    MaxParticipants = 30,
                    Description = "Kadıköy etkinliği açıklaması",
                    Latitude = 40989045960875176,
                    Longitude = 29024591445922856
                },
                new Event
                {
                    EventId = 3,
                    Name = "Beşiktaş",
                    StartDate = new DateTime(2024, 11, 14, 11, 0, 0),
                    EndDate = new DateTime(2024, 11, 14, 19, 0, 0),
                    Location = "Beşiktaş",
                    City = "İstanbul",
                    District = "Beşiktaş",
                    CategoryId = 3,
                    MaxParticipants = 20,
                    Description = "Beşiktaş etkinliği açıklaması",
                    Latitude = 41040932869206168,
                    Longitude = 29000301361083988
                }
            );
        }
    }
}
