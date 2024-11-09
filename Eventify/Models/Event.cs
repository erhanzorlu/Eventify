using Eventify.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Eventify.Models
{
    public class Event
    {
        [Key]
        public Guid EventId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        [MaxLength(500)]
        public string Location { get; set; }

        public bool IsFree { get; set; }

        public decimal? Price { get; set; } // Fiyat, paralı etkinlikler için

        public int? MaxParticipants { get; set; } // Kontenjan sınırı

        [MaxLength(50)]
        public Gender? GenderRestriction { get; set; } // Örnek: "Female", "Male", null (kısıtlama yok)

        public int? AgeLimit { get; set; } // Örnek: 18 (18 yaşından büyükler için)

        [Required]
        public string Description { get; set; }

        public List<UserEvent> UserEvents { get; set; } // Katılımcılar ile ilişki

        // İlgili alanlar için navigation properties eklenebilir (örneğin, kategori veya organizatör)
    }
}
