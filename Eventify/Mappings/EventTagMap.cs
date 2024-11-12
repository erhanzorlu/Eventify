using Eventify.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventify.Mappings
{
    public class EventTagMap : IEntityTypeConfiguration<EventTag>
    {
        public void Configure(EntityTypeBuilder<EventTag> builder)
        {
            builder.HasData(
      new EventTag {Id=1, EventId = 1, TagId = 1 },
      new EventTag {Id=2, EventId = 1, TagId = 2 },
      new EventTag { Id = 3, EventId = 1, TagId = 3 },
      new EventTag { Id = 4, EventId = 1, TagId = 4 },
      new EventTag { Id = 5, EventId = 1, TagId = 6 },
      new EventTag { Id = 6, EventId = 1, TagId = 12 },

      new EventTag { Id = 7, EventId = 2, TagId = 3 },
      new EventTag { Id = 8, EventId = 2, TagId = 7 },
      new EventTag { Id = 9, EventId = 2, TagId = 9 },
      new EventTag { Id = 10, EventId = 2, TagId = 12 },
      new EventTag { Id = 11, EventId = 2, TagId = 15 },
      new EventTag { Id = 12, EventId = 2, TagId = 17 },

      new EventTag { Id = 13, EventId = 3, TagId = 32 },
      new EventTag { Id = 14, EventId = 3, TagId = 33 },
      new EventTag { Id = 15, EventId = 3, TagId = 34 },
      new EventTag { Id = 16, EventId = 3, TagId = 35 },
      new EventTag { Id = 17, EventId = 3, TagId = 50 },
      new EventTag { Id = 18, EventId = 3, TagId = 53 }
  );

        }
    }
}
