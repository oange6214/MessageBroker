using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageBroker.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Messages",
                newName: "TopicMessage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TopicMessage",
                table: "Messages",
                newName: "Name");
        }
    }
}
