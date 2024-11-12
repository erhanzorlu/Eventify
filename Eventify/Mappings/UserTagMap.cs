using Eventify.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventify.Mappings
{
    public class UserTagMap : IEntityTypeConfiguration<UserTag>
    {
        public void Configure(EntityTypeBuilder<UserTag> builder)
        {
            builder.HasData(
                new UserTag { UserId = Guid.Parse("36e3deff-9244-4cfb-b883-790964e88e55"), TagId = 1 },
                new UserTag { UserId = Guid.Parse("36e3deff-9244-4cfb-b883-790964e88e55"), TagId = 3 },
                new UserTag { UserId = Guid.Parse("36e3deff-9244-4cfb-b883-790964e88e55"), TagId = 5 },
                new UserTag { UserId = Guid.Parse("36e3deff-9244-4cfb-b883-790964e88e55"), TagId = 7 },

                new UserTag { UserId = Guid.Parse("5fd1dfba-c0f1-402a-ae7a-821fca498529"), TagId = 2 },
                new UserTag { UserId = Guid.Parse("5fd1dfba-c0f1-402a-ae7a-821fca498529"), TagId = 4 },
                new UserTag { UserId = Guid.Parse("5fd1dfba-c0f1-402a-ae7a-821fca498529"), TagId = 6 },
                new UserTag { UserId = Guid.Parse("5fd1dfba-c0f1-402a-ae7a-821fca498529"), TagId = 8 },

                new UserTag { UserId = Guid.Parse("5bac23ea-d303-44cb-b859-c25285bf0b47"), TagId = 5 },
                new UserTag { UserId = Guid.Parse("5bac23ea-d303-44cb-b859-c25285bf0b47"), TagId = 10 },
                new UserTag { UserId = Guid.Parse("5bac23ea-d303-44cb-b859-c25285bf0b47"), TagId = 15 },
                new UserTag { UserId = Guid.Parse("5bac23ea-d303-44cb-b859-c25285bf0b47"), TagId = 20 }
                );
        }
    }
}
