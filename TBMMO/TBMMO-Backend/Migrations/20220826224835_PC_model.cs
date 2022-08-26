using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TBMMO_Backend.Migrations
{
    public partial class PC_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerCharacters",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCharacters", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Clothing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerCharacterName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clothing_PlayerCharacters_PlayerCharacterName",
                        column: x => x.PlayerCharacterName,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventory_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionSheet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionSheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionSheet_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelationshipSheet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationshipSheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelationshipSheet_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillSheet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillSheet_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatSheet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatSheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatSheet_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clothing_PlayerCharacterName",
                table: "Clothing",
                column: "PlayerCharacterName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_PlayerCharacterId",
                table: "Inventory",
                column: "PlayerCharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionSheet_PlayerCharacterId",
                table: "ProfessionSheet",
                column: "PlayerCharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RelationshipSheet_PlayerCharacterId",
                table: "RelationshipSheet",
                column: "PlayerCharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SkillSheet_PlayerCharacterId",
                table: "SkillSheet",
                column: "PlayerCharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StatSheet_PlayerCharacterId",
                table: "StatSheet",
                column: "PlayerCharacterId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clothing");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "ProfessionSheet");

            migrationBuilder.DropTable(
                name: "RelationshipSheet");

            migrationBuilder.DropTable(
                name: "SkillSheet");

            migrationBuilder.DropTable(
                name: "StatSheet");

            migrationBuilder.DropTable(
                name: "PlayerCharacters");
        }
    }
}
