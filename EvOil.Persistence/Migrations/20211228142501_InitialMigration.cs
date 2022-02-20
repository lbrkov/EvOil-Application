using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvOil.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypeofUser = table.Column<string>(name: "Type of User", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfSession = table.Column<int>(type: "int", nullable: false),
                    OilId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluationSessions_Oils_OilId",
                        column: x => x.OilId,
                        principalTable: "Oils",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    OilId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    EvaluationSessionsId = table.Column<int>(type: "int", nullable: true),
                    Inflamed = table.Column<float>(type: "real", nullable: false),
                    Moldy = table.Column<float>(type: "real", nullable: false),
                    Sour = table.Column<float>(type: "real", nullable: false),
                    Frosted = table.Column<float>(type: "real", nullable: false),
                    Burned = table.Column<float>(type: "real", nullable: false),
                    Fruity = table.Column<float>(type: "real", nullable: false),
                    Spicy = table.Column<float>(type: "real", nullable: false),
                    Bitter = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => new { x.UserId, x.OilId });
                    table.ForeignKey(
                        name: "FK_Evaluations_EvaluationSessions_EvaluationSessionsId",
                        column: x => x.EvaluationSessionsId,
                        principalTable: "EvaluationSessions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Evaluations_Oils_OilId",
                        column: x => x.OilId,
                        principalTable: "Oils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_EvaluationSessionsId",
                table: "Evaluations",
                column: "EvaluationSessionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_OilId",
                table: "Evaluations",
                column: "OilId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationSessions_OilId",
                table: "EvaluationSessions",
                column: "OilId");

            migrationBuilder.CreateIndex(
                name: "IX_Oils_CodeName",
                table: "Oils",
                column: "CodeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "EvaluationSessions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Oils");
        }
    }
}
