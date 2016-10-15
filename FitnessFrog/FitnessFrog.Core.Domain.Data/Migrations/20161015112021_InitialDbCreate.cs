using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FitnessFrog.Core.Domain.Data.Migrations
{
    public partial class InitialDbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "FitnessFrog");

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "FitnessFrog",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 884, DateTimeKind.Local)),
                    EmailAddress = table.Column<string>(maxLength: 128, nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    LastLoginDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 900, DateTimeKind.Local)),
                    LastLoginIp = table.Column<string>(maxLength: 32, nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 900, DateTimeKind.Local)),
                    Name = table.Column<string>(maxLength: 64, nullable: false),
                    Password = table.Column<string>(maxLength: 256, nullable: false),
                    PasswordRecoveryAnswer = table.Column<string>(maxLength: 64, nullable: true),
                    PasswordRecoveryQuestion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                schema: "FitnessFrog",
                columns: table => new
                {
                    DayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 915, DateTimeKind.Local)),
                    EntryDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 915, DateTimeKind.Local)),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 915, DateTimeKind.Local)),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.DayId);
                    table.ForeignKey(
                        name: "FK_Days_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "FitnessFrog",
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                schema: "FitnessFrog",
                columns: table => new
                {
                    NoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 947, DateTimeKind.Local)),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 947, DateTimeKind.Local)),
                    NoteDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 947, DateTimeKind.Local)),
                    NoteText = table.Column<string>(maxLength: 4096, nullable: false),
                    NoteType = table.Column<string>(maxLength: 64, nullable: false),
                    NoteTypeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NoteId);
                    table.ForeignKey(
                        name: "FK_Notes_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "FitnessFrog",
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                schema: "FitnessFrog",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 931, DateTimeKind.Local)),
                    DayId = table.Column<int>(nullable: false),
                    ExerciseType = table.Column<string>(maxLength: 64, nullable: false),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 931, DateTimeKind.Local)),
                    Reps = table.Column<int>(nullable: false),
                    Sets = table.Column<int>(nullable: false),
                    UnitType = table.Column<string>(maxLength: 64, nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseId);
                    table.ForeignKey(
                        name: "FK_Exercises_Days_DayId",
                        column: x => x.DayId,
                        principalSchema: "FitnessFrog",
                        principalTable: "Days",
                        principalColumn: "DayId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exercises_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "FitnessFrog",
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                schema: "FitnessFrog",
                columns: table => new
                {
                    FoodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Calories = table.Column<int>(nullable: false),
                    Carbs = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 931, DateTimeKind.Local)),
                    DayId = table.Column<int>(nullable: false),
                    Fats = table.Column<int>(nullable: false),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2016, 10, 15, 7, 20, 9, 931, DateTimeKind.Local)),
                    Name = table.Column<string>(maxLength: 64, nullable: false),
                    Proteins = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_Days_DayId",
                        column: x => x.DayId,
                        principalSchema: "FitnessFrog",
                        principalTable: "Days",
                        principalColumn: "DayId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Foods_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "FitnessFrog",
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Days_UserId",
                schema: "FitnessFrog",
                table: "Days",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_DayId",
                schema: "FitnessFrog",
                table: "Exercises",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_UserId",
                schema: "FitnessFrog",
                table: "Exercises",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_DayId",
                schema: "FitnessFrog",
                table: "Foods",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_UserId",
                schema: "FitnessFrog",
                table: "Foods",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UserId",
                schema: "FitnessFrog",
                table: "Notes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises",
                schema: "FitnessFrog");

            migrationBuilder.DropTable(
                name: "Foods",
                schema: "FitnessFrog");

            migrationBuilder.DropTable(
                name: "Notes",
                schema: "FitnessFrog");

            migrationBuilder.DropTable(
                name: "Days",
                schema: "FitnessFrog");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "FitnessFrog");
        }
    }
}
