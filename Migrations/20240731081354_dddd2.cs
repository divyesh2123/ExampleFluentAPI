using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleFluentAPI.Migrations
{
    /// <inheritdoc />
    public partial class dddd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentName",
                schema: "Admin",
                table: "StudentInfo",
                newName: "name");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "Admin",
                table: "StudentInfo",
                type: "nvarchar(233)",
                fixedLength: true,
                maxLength: 233,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                schema: "Admin",
                table: "StudentInfo",
                newName: "StudentName");

            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                schema: "Admin",
                table: "StudentInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(233)",
                oldFixedLength: true,
                oldMaxLength: 233)
                .OldAnnotation("Relational:ColumnOrder", 3);
        }
    }
}
