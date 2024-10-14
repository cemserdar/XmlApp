using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XmlApp.Migrations
{
    /// <inheritdoc />
    public partial class fii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SBIFBilgileri_sbifGumrukBilgileri_SbifGumrukBilgileriId",
                table: "SBIFBilgileri");

            migrationBuilder.AlterColumn<int>(
                name: "SbifGumrukBilgileriId",
                table: "SBIFBilgileri",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SBIFBilgileri_sbifGumrukBilgileri_SbifGumrukBilgileriId",
                table: "SBIFBilgileri",
                column: "SbifGumrukBilgileriId",
                principalTable: "sbifGumrukBilgileri",
                principalColumn: "SbifGumrukBilgileriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SBIFBilgileri_sbifGumrukBilgileri_SbifGumrukBilgileriId",
                table: "SBIFBilgileri");

            migrationBuilder.AlterColumn<int>(
                name: "SbifGumrukBilgileriId",
                table: "SBIFBilgileri",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SBIFBilgileri_sbifGumrukBilgileri_SbifGumrukBilgileriId",
                table: "SBIFBilgileri",
                column: "SbifGumrukBilgileriId",
                principalTable: "sbifGumrukBilgileri",
                principalColumn: "SbifGumrukBilgileriId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
