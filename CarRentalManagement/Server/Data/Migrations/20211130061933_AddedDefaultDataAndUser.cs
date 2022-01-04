using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "1da846f7-8654-4348-a277-f5a7b5c8649f", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "4254ab79-e59d-4bb3-a4eb-4817b1b3ba56", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MyProperty", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "91a08a30-7901-4b67-a5b6-646c83cb0327", "admin@localhost.com", false, "Admin", "User", false, null, 0, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAELMkOqyx2eugpdUJtg7nkdmhG5+L7NEWHMf4qTmqF4sMiiR1cyneB/w5PkZVdEDeNA==", null, false, "006f3ab0-efb7-448f-8449-02daf79f7a1a", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 30, 14, 19, 32, 531, DateTimeKind.Local).AddTicks(6270), new DateTime(2021, 11, 30, 14, 19, 32, 532, DateTimeKind.Local).AddTicks(4256), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 30, 14, 19, 32, 532, DateTimeKind.Local).AddTicks(5076), new DateTime(2021, 11, 30, 14, 19, 32, 532, DateTimeKind.Local).AddTicks(5080), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 30, 14, 19, 32, 533, DateTimeKind.Local).AddTicks(5712), new DateTime(2021, 11, 30, 14, 19, 32, 533, DateTimeKind.Local).AddTicks(5719), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 30, 14, 19, 32, 533, DateTimeKind.Local).AddTicks(5722), new DateTime(2021, 11, 30, 14, 19, 32, 533, DateTimeKind.Local).AddTicks(5723), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 30, 14, 19, 32, 533, DateTimeKind.Local).AddTicks(9047), new DateTime(2021, 11, 30, 14, 19, 32, 533, DateTimeKind.Local).AddTicks(9053), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 30, 14, 19, 32, 533, DateTimeKind.Local).AddTicks(9055), new DateTime(2021, 11, 30, 14, 19, 32, 533, DateTimeKind.Local).AddTicks(9056), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 30, 14, 19, 32, 533, DateTimeKind.Local).AddTicks(9126), new DateTime(2021, 11, 30, 14, 19, 32, 533, DateTimeKind.Local).AddTicks(9127), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 30, 14, 19, 32, 533, DateTimeKind.Local).AddTicks(9129), new DateTime(2021, 11, 30, 14, 19, 32, 533, DateTimeKind.Local).AddTicks(9130), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
