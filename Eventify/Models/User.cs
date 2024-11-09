using Eventify.Models.Enums;

namespace Eventify.Models
{
    public class User
    {
        public Guid UserId { get; set; } // Benzersiz kullanıcı kimliği
        public string UserName { get; set; } // Kullanıcı adı
        public string PasswordHash { get; set; } // Şifre (hashlenmiş)
        public string FirstName { get; set; } // İsim
        public string LastName { get; set; } // Soyisim
        public string Email { get; set; } // E-posta
        public DateTime DateOfBirth { get; set; } // Doğum tarihi
        public double? Latitude { get; set; } // Enlem
        public double? Longitude { get; set; } // Boylam
        public Gender Gender { get; set; } // Cinsiyet enum'u
        public DateTime CreatedAt { get; set; } // Oluşturulma tarihi
        public DateTime? UpdatedAt { get; set; } // Güncellenme tarihi

        // Kullanıcının etkinliklerle olan ilişkisi
        public ICollection<UserEvent> UserEvents { get; set; }
    }
}
