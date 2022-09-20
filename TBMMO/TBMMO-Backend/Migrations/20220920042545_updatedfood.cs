using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TBMMO_Backend.Migrations
{
    public partial class updatedfood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "PlayerCharacter");

            migrationBuilder.RenameColumn(
                name: "PlayerCharacterId",
                table: "StatSheets",
                newName: "PlayerCharacterName");

            migrationBuilder.RenameIndex(
                name: "IX_StatSheets_PlayerCharacterId",
                table: "StatSheets",
                newName: "IX_StatSheets_PlayerCharacterName");

            migrationBuilder.RenameColumn(
                name: "PlayerCharacterId",
                table: "SkillSheets",
                newName: "PlayerCharacterName");

            migrationBuilder.RenameIndex(
                name: "IX_SkillSheets_PlayerCharacterId",
                table: "SkillSheets",
                newName: "IX_SkillSheets_PlayerCharacterName");

            migrationBuilder.RenameColumn(
                name: "PlayerCharacterId",
                table: "RelationshipSheets",
                newName: "PlayerCharacterName");

            migrationBuilder.RenameIndex(
                name: "IX_RelationshipSheets_PlayerCharacterId",
                table: "RelationshipSheets",
                newName: "IX_RelationshipSheets_PlayerCharacterName");

            migrationBuilder.RenameColumn(
                name: "PlayerCharacterId",
                table: "ProfessionSheets",
                newName: "PlayerCharacterName");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessionSheets_PlayerCharacterId",
                table: "ProfessionSheets",
                newName: "IX_ProfessionSheets_PlayerCharacterName");

            migrationBuilder.RenameColumn(
                name: "PlayerCharacterId",
                table: "Inventory",
                newName: "PlayerCharacterName");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_PlayerCharacterId",
                table: "Inventory",
                newName: "IX_Inventory_PlayerCharacterName");

            migrationBuilder.AddColumn<int>(
                name: "HP",
                table: "StatSheets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Bag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryId = table.Column<int>(type: "int", nullable: true),
                    Slots = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bag_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlayerCharacters",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCharacters", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "PlayerRelationship",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelationshipSheetId = table.Column<int>(type: "int", nullable: false),
                    RelationshipType = table.Column<int>(type: "int", nullable: false),
                    RecipientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerRelationship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerRelationship_RelationshipSheets_RelationshipSheetId",
                        column: x => x.RelationshipSheetId,
                        principalTable: "RelationshipSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profession",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profession", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BagId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClothingId = table.Column<int>(type: "int", nullable: true),
                    EquipText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CookText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Bag_BagId",
                        column: x => x.BagId,
                        principalTable: "Bag",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Items_Clothing_ClothingId",
                        column: x => x.ClothingId,
                        principalTable: "Clothing",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlayerProfession",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionSheetId = table.Column<int>(type: "int", nullable: false),
                    ProfessionId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerProfession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerProfession_Profession_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Profession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerProfession_ProfessionSheets_ProfessionSheetId",
                        column: x => x.ProfessionSheetId,
                        principalTable: "ProfessionSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerSkill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillSheetId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerSkill_SkillSheets_SkillSheetId",
                        column: x => x.SkillSheetId,
                        principalTable: "SkillSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bag_InventoryId",
                table: "Bag",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_BagId",
                table: "Items",
                column: "BagId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ClothingId",
                table: "Items",
                column: "ClothingId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerProfession_ProfessionId",
                table: "PlayerProfession",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerProfession_ProfessionSheetId",
                table: "PlayerProfession",
                column: "ProfessionSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerRelationship_RelationshipSheetId",
                table: "PlayerRelationship",
                column: "RelationshipSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerSkill_SkillId",
                table: "PlayerSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerSkill_SkillSheetId",
                table: "PlayerSkill",
                column: "SkillSheetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothing_PlayerCharacters_PlayerCharacterName",
                table: "Clothing",
                column: "PlayerCharacterName",
                principalTable: "PlayerCharacters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_PlayerCharacters_PlayerCharacterName",
                table: "Inventory",
                column: "PlayerCharacterName",
                principalTable: "PlayerCharacters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionSheets_PlayerCharacters_PlayerCharacterName",
                table: "ProfessionSheets",
                column: "PlayerCharacterName",
                principalTable: "PlayerCharacters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RelationshipSheets_PlayerCharacters_PlayerCharacterName",
                table: "RelationshipSheets",
                column: "PlayerCharacterName",
                principalTable: "PlayerCharacters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillSheets_PlayerCharacters_PlayerCharacterName",
                table: "SkillSheets",
                column: "PlayerCharacterName",
                principalTable: "PlayerCharacters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatSheets_PlayerCharacters_PlayerCharacterName",
                table: "StatSheets",
                column: "PlayerCharacterName",
                principalTable: "PlayerCharacters",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothing_PlayerCharacters_PlayerCharacterName",
                table: "Clothing");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_PlayerCharacters_PlayerCharacterName",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionSheets_PlayerCharacters_PlayerCharacterName",
                table: "ProfessionSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_RelationshipSheets_PlayerCharacters_PlayerCharacterName",
                table: "RelationshipSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillSheets_PlayerCharacters_PlayerCharacterName",
                table: "SkillSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_StatSheets_PlayerCharacters_PlayerCharacterName",
                table: "StatSheets");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "PlayerCharacters");

            migrationBuilder.DropTable(
                name: "PlayerProfession");

            migrationBuilder.DropTable(
                name: "PlayerRelationship");

            migrationBuilder.DropTable(
                name: "PlayerSkill");

            migrationBuilder.DropTable(
                name: "Bag");

            migrationBuilder.DropTable(
                name: "Profession");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropColumn(
                name: "HP",
                table: "StatSheets");

            migrationBuilder.RenameColumn(
                name: "PlayerCharacterName",
                table: "StatSheets",
                newName: "PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_StatSheets_PlayerCharacterName",
                table: "StatSheets",
                newName: "IX_StatSheets_PlayerCharacterId");

            migrationBuilder.RenameColumn(
                name: "PlayerCharacterName",
                table: "SkillSheets",
                newName: "PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_SkillSheets_PlayerCharacterName",
                table: "SkillSheets",
                newName: "IX_SkillSheets_PlayerCharacterId");

            migrationBuilder.RenameColumn(
                name: "PlayerCharacterName",
                table: "RelationshipSheets",
                newName: "PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_RelationshipSheets_PlayerCharacterName",
                table: "RelationshipSheets",
                newName: "IX_RelationshipSheets_PlayerCharacterId");

            migrationBuilder.RenameColumn(
                name: "PlayerCharacterName",
                table: "ProfessionSheets",
                newName: "PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessionSheets_PlayerCharacterName",
                table: "ProfessionSheets",
                newName: "IX_ProfessionSheets_PlayerCharacterId");

            migrationBuilder.RenameColumn(
                name: "PlayerCharacterName",
                table: "Inventory",
                newName: "PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_PlayerCharacterName",
                table: "Inventory",
                newName: "IX_Inventory_PlayerCharacterId");

            migrationBuilder.CreateTable(
                name: "PlayerCharacter",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCharacter", x => x.Name);
                });

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
    }
}
