using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Training_Backend_Dever.Migrations
{
    /// <inheritdoc />
    public partial class M2_More_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Student",
                newName: "StudentName");

            migrationBuilder.AddColumn<Guid>(
                name: "ClassroomId",
                table: "Student",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Classroom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ClassroomNumber = table.Column<string>(type: "VARCHAR(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classroom", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassroomId",
                table: "Student",
                column: "ClassroomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Classroom_ClassroomId",
                table: "Student",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Classroom_ClassroomId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Classroom");

            migrationBuilder.DropIndex(
                name: "IX_Student_ClassroomId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ClassroomId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Student",
                newName: "Name");
        }
    }
}
