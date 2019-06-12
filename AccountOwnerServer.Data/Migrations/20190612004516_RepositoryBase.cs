using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountOwnerServer.Data.Migrations
{
    public partial class RepositoryBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "owner",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "account",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "owner",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "account",
                newName: "AccountId");
        }
    }
}
