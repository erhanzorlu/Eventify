﻿using Eventify.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eventify.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        [MaxLength(500)]
        public string Location { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; } // İl alanı

        [Required]
        [MaxLength(100)]
        public string District { get; set; } // İlçe alanı

        public bool IsFree { get; set; }

        public decimal? Price { get; set; } // Fiyat, paralı etkinlikler için

        public int? MaxParticipants { get; set; } // Kontenjan sınırı

        [MaxLength(50)]
        public Gender? GenderRestriction { get; set; } // Örnek: "Female", "Male", null (kısıtlama yok)

        public int? AgeLimit { get; set; } // Örnek: 18 (18 yaşından büyükler için)

        [Required]
        public string Description { get; set; }

        public double Latitude { get; set; } // Enlem
        public double Longitude { get; set; } // Boylam

        public int CategoryId { get; set; }
        public Category Category { get; set; } // Kategori ile ilişki

        public List<UserEvent> UserEvents { get; set; } // Katılımcılar ile ilişki
        public List<EventTag> EventTags { get; set; } // Katılımcılar ile ilişki

        // İlgili alanlar için navigation properties eklenebilir (örneğin, kategori veya organizatör)
    }
}
