using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arkadas",
                columns: table => new
                {
                    ArkadasID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kisi = table.Column<int>(type: "int", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arkadas", x => x.ArkadasID);
                });

            migrationBuilder.CreateTable(
                name: "Bolums",
                columns: table => new
                {
                    BolumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolums", x => x.BolumID);
                });

            migrationBuilder.CreateTable(
                name: "Cevaps",
                columns: table => new
                {
                    CevapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GonderenKisi = table.Column<int>(type: "int", nullable: true),
                    Puan = table.Column<int>(type: "int", nullable: true),
                    SoruId = table.Column<int>(type: "int", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cevaps", x => x.CevapID);
                });

            migrationBuilder.CreateTable(
                name: "Etikets",
                columns: table => new
                {
                    EtiketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<int>(type: "int", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etikets", x => x.EtiketID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OkulAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BolumAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mezun = table.Column<bool>(type: "bit", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "Lises",
                columns: table => new
                {
                    LiseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lises", x => x.LiseID);
                });

            migrationBuilder.CreateTable(
                name: "Mesajs",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GonderenKisi = table.Column<int>(type: "int", nullable: true),
                    AlanKisi = table.Column<int>(type: "int", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajs", x => x.MesajID);
                });

            migrationBuilder.CreateTable(
                name: "Sayfas",
                columns: table => new
                {
                    SayfaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnaSayfaID = table.Column<int>(type: "int", nullable: true),
                    Adi = table.Column<int>(type: "int", nullable: true),
                    Url = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sayfas", x => x.SayfaID);
                });

            migrationBuilder.CreateTable(
                name: "Sorus",
                columns: table => new
                {
                    SoruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GonderenKisi = table.Column<int>(type: "int", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sorus", x => x.SoruID);
                });

            migrationBuilder.CreateTable(
                name: "Universites",
                columns: table => new
                {
                    UniversiteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universites", x => x.UniversiteID);
                });

            migrationBuilder.CreateTable(
                name: "Yetkis",
                columns: table => new
                {
                    YetkiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<int>(type: "int", nullable: true),
                    Kullanici = table.Column<int>(type: "int", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetkis", x => x.YetkiID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arkadas");

            migrationBuilder.DropTable(
                name: "Bolums");

            migrationBuilder.DropTable(
                name: "Cevaps");

            migrationBuilder.DropTable(
                name: "Etikets");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Lises");

            migrationBuilder.DropTable(
                name: "Mesajs");

            migrationBuilder.DropTable(
                name: "Sayfas");

            migrationBuilder.DropTable(
                name: "Sorus");

            migrationBuilder.DropTable(
                name: "Universites");

            migrationBuilder.DropTable(
                name: "Yetkis");
        }
    }
}
