using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eventify.Migrations
{
    /// <inheritdoc />
    public partial class FirstMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    District = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsFree = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaxParticipants = table.Column<int>(type: "int", nullable: true),
                    GenderRestriction = table.Column<int>(type: "int", maxLength: 50, nullable: true),
                    AgeLimit = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCategories_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCategories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTags_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTags_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventTags_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventTags_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEvents",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvents", x => new { x.UserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_UserEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Sanat ve Kültür" },
                    { 2, "Eğitim ve Gelişim" },
                    { 3, "Spor ve Sağlık" },
                    { 4, "Sosyal ve Eğlence" },
                    { 5, "Çocuk ve Aile" },
                    { 6, "Çevre ve Doğa" },
                    { 7, "Tasarım ve Yaratıcılık" },
                    { 8, "Teknoloji ve Bilim" },
                    { 9, "Gönüllülük ve Sosyal Sorumluluk" },
                    { 10, "Gastronomi" }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { 1, "Tiyatro" },
                    { 2, "Sergi" },
                    { 3, "Müzik ve Konser" },
                    { 4, "Sinema ve Film Gösterimi" },
                    { 5, "Edebiyat ve Kitap" },
                    { 6, "Tarih ve Arkeoloji" },
                    { 7, "Workshop (Atölye Çalışmaları)" },
                    { 8, "Seminer ve Konferans" },
                    { 9, "Kişisel Gelişim" },
                    { 10, "Dil Kursları" },
                    { 11, "Kariyer ve İş Dünyası" },
                    { 12, "Bilim ve Teknoloji" },
                    { 13, "Spor Müsabakaları" },
                    { 14, "Fitness ve Egzersiz" },
                    { 15, "Yoga ve Meditasyon" },
                    { 16, "Doğa Yürüyüşleri" },
                    { 17, "Bisiklet Turları" },
                    { 18, "Sağlıklı Yaşam Seminerleri" },
                    { 19, "Parti ve Gece Hayatı" },
                    { 20, "Stand-up ve Komedi Gösterisi" },
                    { 21, "Festivaller" },
                    { 22, "Yemek ve Tatma Etkinlikleri" },
                    { 23, "Dans ve Performans Sanatları" },
                    { 24, "Oyun Geceleri" },
                    { 25, "Çocuk Tiyatroları" },
                    { 26, "Aile Etkinlikleri" },
                    { 27, "Çocuk Atölyeleri" },
                    { 28, "Eğitim Etkinlikleri" },
                    { 29, "Hayvanat Bahçesi ve Akvaryum Ziyaretleri" },
                    { 30, "Ekolojik Etkinlikler" },
                    { 31, "Doğa Gözlemleri" },
                    { 32, "Çevre Temizliği ve Gönüllülük" },
                    { 33, "Çiftlik ve Organik Tarım Gezileri" },
                    { 34, "Kamp ve Dağcılık" },
                    { 35, "El Sanatları" },
                    { 36, "Dijital Sanat ve Medya" },
                    { 37, "Fotoğrafçılık" },
                    { 38, "Resim ve Heykel" },
                    { 39, "Moda ve Stil" },
                    { 40, "Grafik Tasarım" },
                    { 41, "Yapay Zeka ve Makine Öğrenimi" },
                    { 42, "Yazılım ve Kodlama" },
                    { 43, "Girişimcilik ve Startup" },
                    { 44, "İnovasyon ve Ar-Ge" },
                    { 45, "Bilim Fuarları ve Sergiler" },
                    { 46, "Elektronik ve Robotik" },
                    { 47, "Sosyal Yardım Etkinlikleri" },
                    { 48, "Çocuk Destek Programları" },
                    { 49, "Yaşlılara Yardım Etkinlikleri" },
                    { 50, "Çevre Temizliği ve Doğa Koruma" },
                    { 51, "Gıda Bağış ve Toplama Etkinlikleri" },
                    { 52, "Yemek Atölyeleri" },
                    { 53, "Şarap Tadımı" },
                    { 54, "Kahve ve Çikolata Etkinlikleri" },
                    { 55, "Yerel Lezzet Turları" },
                    { 56, "Vegan ve Sağlıklı Yemek Etkinlikleri" },
                    { 57, "Mutfak Kültürü Seminerleri" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "Latitude", "Longitude", "Password", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("36e3deff-9244-4cfb-b883-790964e88e55"), new DateTime(2024, 11, 12, 15, 59, 55, 711, DateTimeKind.Local).AddTicks(629), new DateTime(1992, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "elif.demir@example.com", "Elif", 1, "Demir", 41.051385141155201, 28.920015114165274, "sifre789", null, "kullanici789" },
                    { new Guid("5bac23ea-d303-44cb-b859-c25285bf0b47"), new DateTime(2024, 11, 12, 15, 59, 55, 711, DateTimeKind.Local).AddTicks(620), new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.kaya@example.com", "Mehmet", 2, "Kaya", 40.981988897895867, 29.060479357673827, "sifre456", null, "kullanici456" },
                    { new Guid("5fd1dfba-c0f1-402a-ae7a-821fca498529"), new DateTime(2024, 11, 12, 15, 59, 55, 711, DateTimeKind.Local).AddTicks(561), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.yilmaz@example.com", "Ayşe", 1, "Yılmaz", 41.07506311536477, 29.003208846053397, "sifre123", null, "kullanici123" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "AgeLimit", "CategoryId", "City", "Description", "District", "EndDate", "GenderRestriction", "IsFree", "Latitude", "Location", "Longitude", "MaxParticipants", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { 1, null, 1, "İstanbul", "açıklama", "Fatih", new DateTime(2024, 11, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4100922481235155.0, "Fatih", 28969144821166996.0, 24, "Fatih", null, new DateTime(2024, 11, 12, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, 2, "İstanbul", "Kadıköy etkinliği açıklaması", "Kadıköy", new DateTime(2024, 11, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), null, false, 40989045960875176.0, "Kadıköy", 29024591445922856.0, 30, "Kadıköy", null, new DateTime(2024, 11, 13, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, 3, "İstanbul", "Beşiktaş etkinliği açıklaması", "Beşiktaş", new DateTime(2024, 11, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), null, false, 41040932869206168.0, "Beşiktaş", 29000301361083988.0, 20, "Beşiktaş", null, new DateTime(2024, 11, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EventTags",
                columns: new[] { "Id", "EventId", "TagId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 6 },
                    { 6, 1, 12 },
                    { 7, 2, 3 },
                    { 8, 2, 7 },
                    { 9, 2, 9 },
                    { 10, 2, 12 },
                    { 11, 2, 15 },
                    { 12, 2, 17 },
                    { 13, 3, 32 },
                    { 14, 3, 33 },
                    { 15, 3, 34 },
                    { 16, 3, 35 },
                    { 17, 3, 50 },
                    { 18, 3, 53 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTags_EventId",
                table: "EventTags",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTags_TagId",
                table: "EventTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCategories_CategoryId",
                table: "UserCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCategories_UserId",
                table: "UserCategories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_EventId",
                table: "UserEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTags_TagId",
                table: "UserTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTags_UserId",
                table: "UserTags",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventTags");

            migrationBuilder.DropTable(
                name: "UserCategories");

            migrationBuilder.DropTable(
                name: "UserEvents");

            migrationBuilder.DropTable(
                name: "UserTags");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
