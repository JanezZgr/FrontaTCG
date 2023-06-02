using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FrontaTCG.Migrations
{
    /// <inheritdoc />
    public partial class AddedCards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppCardAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AbilityName = table.Column<string>(type: "text", nullable: false),
                    AbilityDescription = table.Column<string>(type: "text", nullable: false),
                    ActivationCount = table.Column<byte>(type: "smallint", nullable: false),
                    ActivationRange = table.Column<int>(type: "integer", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCardAbilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CardName = table.Column<string>(type: "text", nullable: false),
                    CostMaterial = table.Column<int>(type: "integer", nullable: false),
                    CostManpower = table.Column<int>(type: "integer", nullable: false),
                    Ability1Id = table.Column<int>(type: "integer", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCards_AppCardAbilities_Ability1Id",
                        column: x => x.Ability1Id,
                        principalTable: "AppCardAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUnitCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CardId = table.Column<Guid>(type: "uuid", nullable: false),
                    DmgUnarmored = table.Column<int>(type: "integer", nullable: false),
                    DmgArmored = table.Column<int>(type: "integer", nullable: false),
                    DmgStructure = table.Column<int>(type: "integer", nullable: false),
                    DmgAir = table.Column<int>(type: "integer", nullable: false),
                    Ability2Id = table.Column<int>(type: "integer", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUnitCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUnitCards_AppCardAbilities_Ability2Id",
                        column: x => x.Ability2Id,
                        principalTable: "AppCardAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUnitCards_AppCards_CardId",
                        column: x => x.CardId,
                        principalTable: "AppCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppCards_Ability1Id",
                table: "AppCards",
                column: "Ability1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnitCards_Ability2Id",
                table: "AppUnitCards",
                column: "Ability2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnitCards_CardId",
                table: "AppUnitCards",
                column: "CardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUnitCards");

            migrationBuilder.DropTable(
                name: "AppCards");

            migrationBuilder.DropTable(
                name: "AppCardAbilities");
        }
    }
}
