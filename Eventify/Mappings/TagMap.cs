using Eventify.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Eventify.Mappings
{
    public class TagMap : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasData(
                // Sanat ve Kültür Etiketleri
                new Tag { TagId = 1, Name = "Tiyatro" },
                new Tag { TagId = 2, Name = "Sergi" },
                new Tag { TagId = 3, Name = "Müzik ve Konser" },
                new Tag { TagId = 4, Name = "Sinema ve Film Gösterimi" },
                new Tag { TagId = 5, Name = "Edebiyat ve Kitap" },
                new Tag { TagId = 6, Name = "Tarih ve Arkeoloji" },

                // Eğitim ve Gelişim Etiketleri
                new Tag { TagId = 7, Name = "Workshop (Atölye Çalışmaları)" },
                new Tag { TagId = 8, Name = "Seminer ve Konferans" },
                new Tag { TagId = 9, Name = "Kişisel Gelişim" },
                new Tag { TagId = 10, Name = "Dil Kursları" },
                new Tag { TagId = 11, Name = "Kariyer ve İş Dünyası" },
                new Tag { TagId = 12, Name = "Bilim ve Teknoloji" },

                // Spor ve Sağlık Etiketleri
                new Tag { TagId = 13, Name = "Spor Müsabakaları" },
                new Tag { TagId = 14, Name = "Fitness ve Egzersiz" },
                new Tag { TagId = 15, Name = "Yoga ve Meditasyon" },
                new Tag { TagId = 16, Name = "Doğa Yürüyüşleri" },
                new Tag { TagId = 17, Name = "Bisiklet Turları" },
                new Tag { TagId = 18, Name = "Sağlıklı Yaşam Seminerleri" },

                // Sosyal ve Eğlence Etiketleri
                new Tag { TagId = 19, Name = "Parti ve Gece Hayatı" },
                new Tag { TagId = 20, Name = "Stand-up ve Komedi Gösterisi" },
                new Tag { TagId = 21, Name = "Festivaller" },
                new Tag { TagId = 22, Name = "Yemek ve Tatma Etkinlikleri" },
                new Tag { TagId = 23, Name = "Dans ve Performans Sanatları" },
                new Tag { TagId = 24, Name = "Oyun Geceleri" },

                // Çocuk ve Aile Etiketleri
                new Tag { TagId = 25, Name = "Çocuk Tiyatroları" },
                new Tag { TagId = 26, Name = "Aile Etkinlikleri" },
                new Tag { TagId = 27, Name = "Çocuk Atölyeleri" },
                new Tag { TagId = 28, Name = "Eğitim Etkinlikleri" },
                new Tag { TagId = 29, Name = "Hayvanat Bahçesi ve Akvaryum Ziyaretleri" },

                // Çevre ve Doğa Etiketleri
                new Tag { TagId = 30, Name = "Ekolojik Etkinlikler" },
                new Tag { TagId = 31, Name = "Doğa Gözlemleri" },
                new Tag { TagId = 32, Name = "Çevre Temizliği ve Gönüllülük" },
                new Tag { TagId = 33, Name = "Çiftlik ve Organik Tarım Gezileri" },
                new Tag { TagId = 34, Name = "Kamp ve Dağcılık" },

                // Tasarım ve Yaratıcılık Etiketleri
                new Tag { TagId = 35, Name = "El Sanatları" },
                new Tag { TagId = 36, Name = "Dijital Sanat ve Medya" },
                new Tag { TagId = 37, Name = "Fotoğrafçılık" },
                new Tag { TagId = 38, Name = "Resim ve Heykel" },
                new Tag { TagId = 39, Name = "Moda ve Stil" },
                new Tag { TagId = 40, Name = "Grafik Tasarım" },

                // Teknoloji ve Bilim Etiketleri
                new Tag { TagId = 41, Name = "Yapay Zeka ve Makine Öğrenimi" },
                new Tag { TagId = 42, Name = "Yazılım ve Kodlama" },
                new Tag { TagId = 43, Name = "Girişimcilik ve Startup" },
                new Tag { TagId = 44, Name = "İnovasyon ve Ar-Ge" },
                new Tag { TagId = 45, Name = "Bilim Fuarları ve Sergiler" },
                new Tag { TagId = 46, Name = "Elektronik ve Robotik" },

                // Gönüllülük ve Sosyal Sorumluluk Etiketleri
                new Tag { TagId = 47, Name = "Sosyal Yardım Etkinlikleri" },
                new Tag { TagId = 48, Name = "Çocuk Destek Programları" },
                new Tag { TagId = 49, Name = "Yaşlılara Yardım Etkinlikleri" },
                new Tag { TagId = 50, Name = "Çevre Temizliği ve Doğa Koruma" },
                new Tag { TagId = 51, Name = "Gıda Bağış ve Toplama Etkinlikleri" },

                // Gastronomi Etiketleri
                new Tag { TagId = 52, Name = "Yemek Atölyeleri" },
                new Tag { TagId = 53, Name = "Şarap Tadımı" },
                new Tag { TagId = 54, Name = "Kahve ve Çikolata Etkinlikleri" },
                new Tag { TagId = 55, Name = "Yerel Lezzet Turları" },
                new Tag { TagId = 56, Name = "Vegan ve Sağlıklı Yemek Etkinlikleri" },
                new Tag { TagId = 57, Name = "Mutfak Kültürü Seminerleri" }
            );
        }
    }
}
