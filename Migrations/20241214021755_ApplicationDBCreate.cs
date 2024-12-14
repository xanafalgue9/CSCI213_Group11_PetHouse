using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHouse.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationDBCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdopterId = table.Column<int>(type: "int", nullable: true),
                    PetId = table.Column<int>(type: "int", nullable: true),
                    DateSubmission = table.Column<DateOnly>(type: "date", nullable: false),
                    SubmissionMessage = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DateEvaluation = table.Column<DateOnly>(type: "date", nullable: false),
                    EvaluationMessage = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_Dog_PetId",
                        column: x => x.PetId,
                        principalTable: "Dog",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Application_User_AdopterId",
                        column: x => x.AdopterId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Application_AdopterId",
                table: "Application",
                column: "AdopterId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_PetId",
                table: "Application",
                column: "PetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");
        }
    }
}
