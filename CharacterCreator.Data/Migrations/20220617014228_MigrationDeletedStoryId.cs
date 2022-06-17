using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Data.Migrations
{
    public partial class MigrationDeletedStoryId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_Story_StoryId",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_StoryId",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "StoryId",
                table: "Character");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoryId",
                table: "Character",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Character_StoryId",
                table: "Character",
                column: "StoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Story_StoryId",
                table: "Character",
                column: "StoryId",
                principalTable: "Story",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
