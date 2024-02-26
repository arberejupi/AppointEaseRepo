using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppointEase.Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1365e446-7397-48e6-b85f-0353ef916d93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d7e0603-d01f-4e8d-b5b9-54f01af5affc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4dbf294-89ee-4c5c-8fb6-bf31301ffb61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6bfb572-067b-41d3-b1ae-58a020a8124a");

            migrationBuilder.DropColumn(
                name: "PersonalNumber",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PersonalNumber",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalNumber",
                table: "Doctor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateOnly>(
                name: "CreatedDate",
                table: "Clinic",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Admin",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PersonalNumber",
                table: "Admin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0356d7c4-5063-4887-a2ec-cfd156479843", "4", "Patient", "Patient" },
                    { "2eac680d-997f-45bc-b102-d214894cfd4c", "2", "Clinic", "Clinic" },
                    { "800c4ef8-7d31-45b2-b0b8-ec754c0bfc7e", "1", "Admin", "Admin" },
                    { "ac8815cd-d75a-4162-ba96-a983daf68070", "3", "Doctor", "Doctor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0356d7c4-5063-4887-a2ec-cfd156479843");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2eac680d-997f-45bc-b102-d214894cfd4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800c4ef8-7d31-45b2-b0b8-ec754c0bfc7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac8815cd-d75a-4162-ba96-a983daf68070");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "PersonalNumber",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "PersonalNumber",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Clinic");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "PersonalNumber",
                table: "Admin");

            migrationBuilder.AddColumn<int>(
                name: "PersonalNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1365e446-7397-48e6-b85f-0353ef916d93", "2", "Clinic", "Clinic" },
                    { "3d7e0603-d01f-4e8d-b5b9-54f01af5affc", "4", "Patient", "Patient" },
                    { "c4dbf294-89ee-4c5c-8fb6-bf31301ffb61", "1", "Admin", "Admin" },
                    { "f6bfb572-067b-41d3-b1ae-58a020a8124a", "3", "Doctor", "Doctor" }
                });
        }
    }
}
