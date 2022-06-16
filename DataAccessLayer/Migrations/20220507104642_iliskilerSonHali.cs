using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class iliskilerSonHali : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Kullanici",
                table: "Yetkis",
                newName: "KullaniciID");

            migrationBuilder.RenameColumn(
                name: "GonderenKisi",
                table: "Sorus",
                newName: "KullaniciID");

            migrationBuilder.RenameColumn(
                name: "GonderenKisi",
                table: "Cevaps",
                newName: "KullaniciID");

            migrationBuilder.RenameColumn(
                name: "Kisi",
                table: "Arkadas",
                newName: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Yetkis_KullaniciID",
                table: "Yetkis",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Sorus_KullaniciID",
                table: "Sorus",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Cevaps_KullaniciID",
                table: "Cevaps",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Arkadas_KullaniciID",
                table: "Arkadas",
                column: "KullaniciID");

            migrationBuilder.AddForeignKey(
                name: "FK_Arkadas_Kullanicis_KullaniciID",
                table: "Arkadas",
                column: "KullaniciID",
                principalTable: "Kullanicis",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cevaps_Kullanicis_KullaniciID",
                table: "Cevaps",
                column: "KullaniciID",
                principalTable: "Kullanicis",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sorus_Kullanicis_KullaniciID",
                table: "Sorus",
                column: "KullaniciID",
                principalTable: "Kullanicis",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Yetkis_Kullanicis_KullaniciID",
                table: "Yetkis",
                column: "KullaniciID",
                principalTable: "Kullanicis",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arkadas_Kullanicis_KullaniciID",
                table: "Arkadas");

            migrationBuilder.DropForeignKey(
                name: "FK_Cevaps_Kullanicis_KullaniciID",
                table: "Cevaps");

            migrationBuilder.DropForeignKey(
                name: "FK_Sorus_Kullanicis_KullaniciID",
                table: "Sorus");

            migrationBuilder.DropForeignKey(
                name: "FK_Yetkis_Kullanicis_KullaniciID",
                table: "Yetkis");

            migrationBuilder.DropIndex(
                name: "IX_Yetkis_KullaniciID",
                table: "Yetkis");

            migrationBuilder.DropIndex(
                name: "IX_Sorus_KullaniciID",
                table: "Sorus");

            migrationBuilder.DropIndex(
                name: "IX_Cevaps_KullaniciID",
                table: "Cevaps");

            migrationBuilder.DropIndex(
                name: "IX_Arkadas_KullaniciID",
                table: "Arkadas");

            migrationBuilder.RenameColumn(
                name: "KullaniciID",
                table: "Yetkis",
                newName: "Kullanici");

            migrationBuilder.RenameColumn(
                name: "KullaniciID",
                table: "Sorus",
                newName: "GonderenKisi");

            migrationBuilder.RenameColumn(
                name: "KullaniciID",
                table: "Cevaps",
                newName: "GonderenKisi");

            migrationBuilder.RenameColumn(
                name: "KullaniciID",
                table: "Arkadas",
                newName: "Kisi");
        }
    }
}
