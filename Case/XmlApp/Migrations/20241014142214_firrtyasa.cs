using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XmlApp.Migrations
{
    /// <inheritdoc />
    public partial class firrtyasa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FonDekont_SBIFBilgileri_SBIFBilgileriId",
                table: "FonDekont");

            migrationBuilder.DropIndex(
                name: "IX_FonDekont_SBIFBilgileriId",
                table: "FonDekont");

            migrationBuilder.DropColumn(
                name: "SBIFBilgileriId",
                table: "FonDekont");

            migrationBuilder.AddColumn<string>(
                name: "FonDekontDekontNo",
                table: "SBIFBilgileri",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SBIFBilgileri_FonDekontDekontNo",
                table: "SBIFBilgileri",
                column: "FonDekontDekontNo");

            migrationBuilder.AddForeignKey(
                name: "FK_SBIFBilgileri_FonDekont_FonDekontDekontNo",
                table: "SBIFBilgileri",
                column: "FonDekontDekontNo",
                principalTable: "FonDekont",
                principalColumn: "FonDekontDekontNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SBIFBilgileri_FonDekont_FonDekontDekontNo",
                table: "SBIFBilgileri");

            migrationBuilder.DropIndex(
                name: "IX_SBIFBilgileri_FonDekontDekontNo",
                table: "SBIFBilgileri");

            migrationBuilder.DropColumn(
                name: "FonDekontDekontNo",
                table: "SBIFBilgileri");

            migrationBuilder.AddColumn<int>(
                name: "SBIFBilgileriId",
                table: "FonDekont",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FonDekont_SBIFBilgileriId",
                table: "FonDekont",
                column: "SBIFBilgileriId",
                unique: true,
                filter: "[SBIFBilgileriId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_FonDekont_SBIFBilgileri_SBIFBilgileriId",
                table: "FonDekont",
                column: "SBIFBilgileriId",
                principalTable: "SBIFBilgileri",
                principalColumn: "Id");
        }
    }
}
