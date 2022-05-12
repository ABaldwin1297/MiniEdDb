using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniEdDb.Migrations
{
    public partial class AddingClassInstructoragain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Classes_Code",
                table: "Classes");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Classes",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Classes",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Code",
                table: "Classes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_InstructorId",
                table: "Classes",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Instructors_InstructorId",
                table: "Classes",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Instructors_InstructorId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_Code",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_InstructorId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Classes");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Classes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Code",
                table: "Classes",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");
        }
    }
}
