using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TBMMO_Backend.Migrations
{
    public partial class placeholder_models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothing_PlayerCharacters_PlayerCharacterName",
                table: "Clothing");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_PlayerCharacters_PlayerCharacterId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionSheet_PlayerCharacters_PlayerCharacterId",
                table: "ProfessionSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_RelationshipSheet_PlayerCharacters_PlayerCharacterId",
                table: "RelationshipSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillSheet_PlayerCharacters_PlayerCharacterId",
                table: "SkillSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_StatSheet_PlayerCharacters_PlayerCharacterId",
                table: "StatSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatSheet",
                table: "StatSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillSheet",
                table: "SkillSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RelationshipSheet",
                table: "RelationshipSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfessionSheet",
                table: "ProfessionSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerCharacters",
                table: "PlayerCharacters");

            migrationBuilder.RenameTable(
                name: "StatSheet",
                newName: "StatSheets");

            migrationBuilder.RenameTable(
                name: "SkillSheet",
                newName: "SkillSheets");

            migrationBuilder.RenameTable(
                name: "RelationshipSheet",
                newName: "RelationshipSheets");

            migrationBuilder.RenameTable(
                name: "ProfessionSheet",
                newName: "ProfessionSheets");

            migrationBuilder.RenameTable(
                name: "PlayerCharacters",
                newName: "PlayerCharacter");

            migrationBuilder.RenameIndex(
                name: "IX_StatSheet_PlayerCharacterId",
                table: "StatSheets",
                newName: "IX_StatSheets_PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_SkillSheet_PlayerCharacterId",
                table: "SkillSheets",
                newName: "IX_SkillSheets_PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_RelationshipSheet_PlayerCharacterId",
                table: "RelationshipSheets",
                newName: "IX_RelationshipSheets_PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessionSheet_PlayerCharacterId",
                table: "ProfessionSheets",
                newName: "IX_ProfessionSheets_PlayerCharacterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatSheets",
                table: "StatSheets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillSheets",
                table: "SkillSheets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RelationshipSheets",
                table: "RelationshipSheets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessionSheets",
                table: "ProfessionSheets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerCharacter",
                table: "PlayerCharacter",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothing_PlayerCharacter_PlayerCharacterName",
                table: "Clothing",
                column: "PlayerCharacterName",
                principalTable: "PlayerCharacter",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_PlayerCharacter_PlayerCharacterId",
                table: "Inventory",
                column: "PlayerCharacterId",
                principalTable: "PlayerCharacter",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionSheets_PlayerCharacter_PlayerCharacterId",
                table: "ProfessionSheets",
                column: "PlayerCharacterId",
                principalTable: "PlayerCharacter",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RelationshipSheets_PlayerCharacter_PlayerCharacterId",
                table: "RelationshipSheets",
                column: "PlayerCharacterId",
                principalTable: "PlayerCharacter",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillSheets_PlayerCharacter_PlayerCharacterId",
                table: "SkillSheets",
                column: "PlayerCharacterId",
                principalTable: "PlayerCharacter",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatSheets_PlayerCharacter_PlayerCharacterId",
                table: "StatSheets",
                column: "PlayerCharacterId",
                principalTable: "PlayerCharacter",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothing_PlayerCharacter_PlayerCharacterName",
                table: "Clothing");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_PlayerCharacter_PlayerCharacterId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionSheets_PlayerCharacter_PlayerCharacterId",
                table: "ProfessionSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_RelationshipSheets_PlayerCharacter_PlayerCharacterId",
                table: "RelationshipSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillSheets_PlayerCharacter_PlayerCharacterId",
                table: "SkillSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_StatSheets_PlayerCharacter_PlayerCharacterId",
                table: "StatSheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatSheets",
                table: "StatSheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillSheets",
                table: "SkillSheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RelationshipSheets",
                table: "RelationshipSheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfessionSheets",
                table: "ProfessionSheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerCharacter",
                table: "PlayerCharacter");

            migrationBuilder.RenameTable(
                name: "StatSheets",
                newName: "StatSheet");

            migrationBuilder.RenameTable(
                name: "SkillSheets",
                newName: "SkillSheet");

            migrationBuilder.RenameTable(
                name: "RelationshipSheets",
                newName: "RelationshipSheet");

            migrationBuilder.RenameTable(
                name: "ProfessionSheets",
                newName: "ProfessionSheet");

            migrationBuilder.RenameTable(
                name: "PlayerCharacter",
                newName: "PlayerCharacters");

            migrationBuilder.RenameIndex(
                name: "IX_StatSheets_PlayerCharacterId",
                table: "StatSheet",
                newName: "IX_StatSheet_PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_SkillSheets_PlayerCharacterId",
                table: "SkillSheet",
                newName: "IX_SkillSheet_PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_RelationshipSheets_PlayerCharacterId",
                table: "RelationshipSheet",
                newName: "IX_RelationshipSheet_PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessionSheets_PlayerCharacterId",
                table: "ProfessionSheet",
                newName: "IX_ProfessionSheet_PlayerCharacterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatSheet",
                table: "StatSheet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillSheet",
                table: "SkillSheet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RelationshipSheet",
                table: "RelationshipSheet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessionSheet",
                table: "ProfessionSheet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerCharacters",
                table: "PlayerCharacters",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothing_PlayerCharacters_PlayerCharacterName",
                table: "Clothing",
                column: "PlayerCharacterName",
                principalTable: "PlayerCharacters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_PlayerCharacters_PlayerCharacterId",
                table: "Inventory",
                column: "PlayerCharacterId",
                principalTable: "PlayerCharacters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionSheet_PlayerCharacters_PlayerCharacterId",
                table: "ProfessionSheet",
                column: "PlayerCharacterId",
                principalTable: "PlayerCharacters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RelationshipSheet_PlayerCharacters_PlayerCharacterId",
                table: "RelationshipSheet",
                column: "PlayerCharacterId",
                principalTable: "PlayerCharacters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillSheet_PlayerCharacters_PlayerCharacterId",
                table: "SkillSheet",
                column: "PlayerCharacterId",
                principalTable: "PlayerCharacters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatSheet_PlayerCharacters_PlayerCharacterId",
                table: "StatSheet",
                column: "PlayerCharacterId",
                principalTable: "PlayerCharacters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
