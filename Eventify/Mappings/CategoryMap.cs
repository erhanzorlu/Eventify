using Eventify.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventify.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { CategoryId = 1, Name = "Sanat ve Kültür" },
                new Category { CategoryId = 2, Name = "Eğitim ve Gelişim" },
                new Category { CategoryId = 3, Name = "Spor ve Sağlık" },
                new Category { CategoryId = 4, Name = "Sosyal ve Eğlence" },
                new Category { CategoryId = 5, Name = "Çocuk ve Aile" },
                new Category { CategoryId = 6, Name = "Çevre ve Doğa" },
                new Category { CategoryId = 7, Name = "Tasarım ve Yaratıcılık" },
                new Category { CategoryId = 8, Name = "Teknoloji ve Bilim" },
                new Category { CategoryId = 9, Name = "Gönüllülük ve Sosyal Sorumluluk" },
                new Category { CategoryId = 10, Name = "Gastronomi" }
            );
        }
    }
}
