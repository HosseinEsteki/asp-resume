using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Resome.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IsAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Image = table.Column<string>(type: "longtext", nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Biography = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(type: "longtext", nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ShortDiscription = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(name: "Updated_At", type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    Gender = table.Column<string>(type: "longtext", nullable: true),
                    Marry = table.Column<string>(type: "longtext", nullable: true),
                    Birth = table.Column<string>(type: "longtext", nullable: true),
                    Sarbaz = table.Column<string>(type: "longtext", nullable: true),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    Maghta1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Reshte1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Uni1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    UniStart1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    UniEnd1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Maghta2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Reshte2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Uni2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    UniStart2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    UniEnd2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Job1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Company1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    City1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    JobStart1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    JobEnd1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Job2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Company2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    City2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    JobStart2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    JobEnd2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Project1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Karfarma1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Link1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ProjectStart1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ProjectEnd1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Project2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Karfarma2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Link2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ProjectStart2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ProjectEnd2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Article1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Nasher1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Mortabet1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ArticleStart1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ArticleEnd1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Article2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Nasher2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Mortabet2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ArticleStart2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ArticleEnd2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UserId",
                table: "Properties",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
