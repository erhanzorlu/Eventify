using Eventify.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventify.Mappings
{
    public class UserCategoryMap : IEntityTypeConfiguration<UserCategory>
    {
        public void Configure(EntityTypeBuilder<UserCategory> builder)
        {
            builder.HasData(
                new UserCategory { UserId = Guid.Parse("36e3deff-9244-4cfb-b883-790964e88e55"), CategoryId = 1 },
                new UserCategory { UserId = Guid.Parse("36e3deff-9244-4cfb-b883-790964e88e55"), CategoryId = 3 },
                new UserCategory { UserId = Guid.Parse("36e3deff-9244-4cfb-b883-790964e88e55"), CategoryId = 5 },


                new UserCategory { UserId = Guid.Parse("5fd1dfba-c0f1-402a-ae7a-821fca498529"), CategoryId = 2 },
                new UserCategory { UserId = Guid.Parse("5fd1dfba-c0f1-402a-ae7a-821fca498529"), CategoryId = 3 },
                new UserCategory { UserId = Guid.Parse("5fd1dfba-c0f1-402a-ae7a-821fca498529"), CategoryId = 7 },

                new UserCategory { UserId = Guid.Parse("5bac23ea-d303-44cb-b859-c25285bf0b47"), CategoryId = 3 },
                new UserCategory { UserId = Guid.Parse("5bac23ea-d303-44cb-b859-c25285bf0b47"), CategoryId = 4},
                new UserCategory { UserId = Guid.Parse("5bac23ea-d303-44cb-b859-c25285bf0b47"), CategoryId = 8 }


                );
        }
    }
}
