using Microsoft.EntityFrameworkCore.Migrations;

namespace libraryManagement.Migrations
{
    public partial class updateAuthorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_Book_BookID",
                table: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Author_BookID",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "BookID",
                table: "Author");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookID",
                table: "Author",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Author_BookID",
                table: "Author",
                column: "BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Book_BookID",
                table: "Author",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
