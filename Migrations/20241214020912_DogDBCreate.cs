using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHouse.Migrations
{
    /// <inheritdoc />
    public partial class DogDBCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DogBreed = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DogAge = table.Column<int>(type: "int", nullable: false),
                    DogSize = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    DogWeight = table.Column<double>(type: "float", nullable: false),
                    DogColor = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DogPersonality = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DogIsFriendlyWithChildren = table.Column<bool>(type: "bit", nullable: false),
                    DogIsFriendlyWithCats = table.Column<bool>(type: "bit", nullable: false),
                    DogHealthInformation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DogIsAdopted = table.Column<bool>(type: "bit", nullable: false),
                    DogPicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdopterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dog_User_AdopterId",
                        column: x => x.AdopterId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dog_AdopterId",
                table: "Dog",
                column: "AdopterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dog");
        }
    }
}
