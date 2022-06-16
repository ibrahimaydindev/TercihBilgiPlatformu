using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class iliskiler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GonderenKisi",
                table: "Mesajs",
                newName: "KullaniciID");

            migrationBuilder.RenameColumn(
                name: "AlanKisi",
                table: "Mesajs",
                newName: "GonderenKullaniciId");

            migrationBuilder.AddColumn<int>(
                name: "AlanKullaniciId",
                table: "Mesajs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UniversiteID",
                table: "Bolums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mesajs_KullaniciID",
                table: "Mesajs",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Bolums_UniversiteID",
                table: "Bolums",
                column: "UniversiteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bolums_Universites_UniversiteID",
                table: "Bolums",
                column: "UniversiteID",
                principalTable: "Universites",
                principalColumn: "UniversiteID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mesajs_Kullanicis_KullaniciID",
                table: "Mesajs",
                column: "KullaniciID",
                principalTable: "Kullanicis",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bolums_Universites_UniversiteID",
                table: "Bolums");

            migrationBuilder.DropForeignKey(
                name: "FK_Mesajs_Kullanicis_KullaniciID",
                table: "Mesajs");

            migrationBuilder.DropIndex(
                name: "IX_Mesajs_KullaniciID",
                table: "Mesajs");

            migrationBuilder.DropIndex(
                name: "IX_Bolums_UniversiteID",
                table: "Bolums");

            migrationBuilder.DropColumn(
                name: "AlanKullaniciId",
                table: "Mesajs");

            migrationBuilder.DropColumn(
                name: "UniversiteID",
                table: "Bolums");

            migrationBuilder.RenameColumn(
                name: "KullaniciID",
                table: "Mesajs",
                newName: "GonderenKisi");

            migrationBuilder.RenameColumn(
                name: "GonderenKullaniciId",
                table: "Mesajs",
                newName: "AlanKisi");
        }
    }
}
