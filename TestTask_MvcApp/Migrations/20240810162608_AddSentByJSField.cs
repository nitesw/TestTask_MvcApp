using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTask_MvcApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSentByJSField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SentByJS",
                table: "Persons",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SentByJS",
                table: "Persons");
        }
    }
}
