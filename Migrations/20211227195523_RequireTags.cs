using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class RequireTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Products_Productid",
                table: "Tag");

            migrationBuilder.AlterColumn<int>(
                name: "Productid",
                table: "Tag",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Products_Productid",
                table: "Tag",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Products_Productid",
                table: "Tag");

            migrationBuilder.AlterColumn<int>(
                name: "Productid",
                table: "Tag",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Products_Productid",
                table: "Tag",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "id");
        }
    }
}
