using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicPerformanceSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamScore = table.Column<double>(type: "float", nullable: false),
                    AttendanceRate = table.Column<double>(type: "float", nullable: false),
                    PracticalScore = table.Column<double>(type: "float", nullable: false),
                    ProjectScore = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentData", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentData");
        }
    }
}
