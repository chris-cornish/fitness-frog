using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessFrog.Core.Domain.Data.Migrations
{
    public partial class updatedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExerciseName",
                schema: "FitnessFrog",
                table: "Exercises",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                schema: "FitnessFrog",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 70, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastLoginDate",
                schema: "FitnessFrog",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 70, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                schema: "FitnessFrog",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 58, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NoteDate",
                schema: "FitnessFrog",
                table: "Notes",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 98, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                schema: "FitnessFrog",
                table: "Notes",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 98, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                schema: "FitnessFrog",
                table: "Notes",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 98, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                schema: "FitnessFrog",
                table: "Foods",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 98, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                schema: "FitnessFrog",
                table: "Foods",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 98, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                schema: "FitnessFrog",
                table: "Exercises",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 90, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                schema: "FitnessFrog",
                table: "Exercises",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 90, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                schema: "FitnessFrog",
                table: "Days",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 82, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EntryDate",
                schema: "FitnessFrog",
                table: "Days",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 82, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                schema: "FitnessFrog",
                table: "Days",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 10, 18, 26, 17, 82, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExerciseName",
                schema: "FitnessFrog",
                table: "Exercises");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                schema: "FitnessFrog",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 167, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastLoginDate",
                schema: "FitnessFrog",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 167, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                schema: "FitnessFrog",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 160, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NoteDate",
                schema: "FitnessFrog",
                table: "Notes",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 194, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                schema: "FitnessFrog",
                table: "Notes",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 194, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                schema: "FitnessFrog",
                table: "Notes",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 194, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                schema: "FitnessFrog",
                table: "Foods",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 189, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                schema: "FitnessFrog",
                table: "Foods",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 189, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                schema: "FitnessFrog",
                table: "Exercises",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 183, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                schema: "FitnessFrog",
                table: "Exercises",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 183, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                schema: "FitnessFrog",
                table: "Days",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 176, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EntryDate",
                schema: "FitnessFrog",
                table: "Days",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 176, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                schema: "FitnessFrog",
                table: "Days",
                nullable: false,
                defaultValue: new DateTime(2016, 10, 15, 11, 0, 58, 176, DateTimeKind.Local));
        }
    }
}
