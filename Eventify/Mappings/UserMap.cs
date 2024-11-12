using Eventify.Models;
using Eventify.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventify.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
          new User { UserId = Guid.NewGuid(), UserName = "kullanici123", Password = "sifre123", FirstName = "Ayşe", LastName = "Yılmaz", Email = "ayse.yilmaz@example.com", DateOfBirth = new DateTime(1990, 5, 15), Gender = (Gender)1, CreatedAt = DateTime.Now,Latitude= 41.07506311536477, Longitude=29.003208846053397 },
          new User { UserId = Guid.NewGuid(), UserName = "kullanici456", Password = "sifre456", FirstName = "Mehmet", LastName = "Kaya", Email = "mehmet.kaya@example.com", DateOfBirth = new DateTime(1985, 3, 10), Gender = (Gender)2, CreatedAt = DateTime.Now, Latitude = 40.98198889789587, Longitude =  29.060479357673827 },
          new User { UserId = Guid.NewGuid(), UserName = "kullanici789", Password = "sifre789", FirstName = "Elif", LastName = "Demir", Email = "elif.demir@example.com", DateOfBirth = new DateTime(1992, 7, 20), Gender = (Gender)1, CreatedAt = DateTime.Now, Latitude = 41.0513851411552, Longitude =  28.920015114165274 }

                );
        }
    }
}
