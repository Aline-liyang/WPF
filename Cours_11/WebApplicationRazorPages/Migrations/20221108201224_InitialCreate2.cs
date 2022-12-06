using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationRazorPages.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NomCompagnie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitreContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodePostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
