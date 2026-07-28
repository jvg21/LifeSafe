using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class projectstart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ulr",
                table: "Books",
                newName: "ULR");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Books",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Ulr",
                table: "Authors",
                newName: "ULR");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ULR",
                table: "Books",
                newName: "Ulr");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Books",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ULR",
                table: "Authors",
                newName: "Ulr");
        }
    }
}
