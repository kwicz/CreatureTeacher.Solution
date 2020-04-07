using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreatureTeacher.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eyes",
                columns: table => new
                {
                    EyeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Codon = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Dominance = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eyes", x => x.EyeId);
                });

            migrationBuilder.CreateTable(
                name: "Heads",
                columns: table => new
                {
                    HeadId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Codon = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Dominance = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heads", x => x.HeadId);
                });

            migrationBuilder.CreateTable(
                name: "Mouths",
                columns: table => new
                {
                    MouthId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Codon = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Dominance = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mouths", x => x.MouthId);
                });

            migrationBuilder.CreateTable(
                name: "Tails",
                columns: table => new
                {
                    TailId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Codon = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Dominance = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tails", x => x.TailId);
                });

            migrationBuilder.CreateTable(
                name: "Creatures",
                columns: table => new
                {
                    CreatureId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Parent1Id = table.Column<int>(nullable: false),
                    Parent2Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    EyeId = table.Column<int>(nullable: false),
                    HeadId = table.Column<int>(nullable: false),
                    MouthId = table.Column<int>(nullable: false),
                    TailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creatures", x => x.CreatureId);
                    table.ForeignKey(
                        name: "FK_Creatures_Eyes_EyeId",
                        column: x => x.EyeId,
                        principalTable: "Eyes",
                        principalColumn: "EyeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Creatures_Heads_HeadId",
                        column: x => x.HeadId,
                        principalTable: "Heads",
                        principalColumn: "HeadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Creatures_Mouths_MouthId",
                        column: x => x.MouthId,
                        principalTable: "Mouths",
                        principalColumn: "MouthId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Creatures_Tails_TailId",
                        column: x => x.TailId,
                        principalTable: "Tails",
                        principalColumn: "TailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_EyeId",
                table: "Creatures",
                column: "EyeId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_HeadId",
                table: "Creatures",
                column: "HeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_MouthId",
                table: "Creatures",
                column: "MouthId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_TailId",
                table: "Creatures",
                column: "TailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Creatures");

            migrationBuilder.DropTable(
                name: "Eyes");

            migrationBuilder.DropTable(
                name: "Heads");

            migrationBuilder.DropTable(
                name: "Mouths");

            migrationBuilder.DropTable(
                name: "Tails");
        }
    }
}
