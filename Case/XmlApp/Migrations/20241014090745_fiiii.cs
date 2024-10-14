using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XmlApp.Migrations
{
    /// <inheritdoc />
    public partial class fiiii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SBIFBilgileri_SbifBilgiFisi_SbifBilgiFisiId",
                table: "SBIFBilgileri");

            migrationBuilder.AlterColumn<int>(
                name: "SbifBilgiFisiId",
                table: "SBIFBilgileri",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SBIFBilgileri_SbifBilgiFisi_SbifBilgiFisiId",
                table: "SBIFBilgileri",
                column: "SbifBilgiFisiId",
                principalTable: "SbifBilgiFisi",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SBIFBilgileri_SbifBilgiFisi_SbifBilgiFisiId",
                table: "SBIFBilgileri");

            migrationBuilder.AlterColumn<int>(
                name: "SbifBilgiFisiId",
                table: "SBIFBilgileri",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SBIFBilgileri_SbifBilgiFisi_SbifBilgiFisiId",
                table: "SBIFBilgileri",
                column: "SbifBilgiFisiId",
                principalTable: "SbifBilgiFisi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
