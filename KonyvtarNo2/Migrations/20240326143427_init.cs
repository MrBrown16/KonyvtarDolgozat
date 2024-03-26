using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KonyvtarNo2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kolcsonzo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SzulIdo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kolcsonzo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kolcsonzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KolcsonzoId = table.Column<int>(type: "int", nullable: false),
                    Iro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mufaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kolcsonzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kolcsonzes_Kolcsonzo_KolcsonzoId",
                        column: x => x.KolcsonzoId,
                        principalTable: "Kolcsonzo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kolcsonzes_KolcsonzoId",
                table: "Kolcsonzes",
                column: "KolcsonzoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kolcsonzes");

            migrationBuilder.DropTable(
                name: "Kolcsonzo");
        }
    }
}
