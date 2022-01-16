using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class _initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "4d38c271-1edb-4090-b068-24d754ce1123");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33546e06-8719-4ad8-b88a-f271ae9d6ecs", "9780d4ce-0fd1-4824-90f3-7339c1998128", "user", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash" },
                values: new object[] { "5c9c7828-a607-46b7-bbde-dab1d4ec761e", "admin@email.com", "AQAAAAEAACcQAAAAEIHgl1r5hvTA/LFvdsZFFe2ZF0g2Z+6OnYojmnZogtMea5wxv8071hGgWZbgtHXmdg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2c62472e-4f66-49fa-a20f-e7685b9565e9", 0, "e40756e8-02bc-43c0-994e-712c0b773f6f", "user@email.com", true, false, null, "MY@EMAIL.COM", "USER", "AQAAAAEAACcQAAAAEDBP0sp5xvOQ8/VMCJwhZH3abq5uIr0wJdRnNbtC0dnQ3jm7W4RB/UNQ+jo9kPI3qg==", null, false, "", false, "user" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 16, 16, 1, 31, 804, DateTimeKind.Utc).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 16, 16, 1, 31, 804, DateTimeKind.Utc).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 16, 16, 1, 31, 804, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "2c62472e-4f66-49fa-a20f-e7685b9565e9", "33546e06-8719-4ad8-b88a-f271ae9d6ecs" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2c62472e-4f66-49fa-a20f-e7685b9565e9", "33546e06-8719-4ad8-b88a-f271ae9d6ecs" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33546e06-8719-4ad8-b88a-f271ae9d6ecs");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c62472e-4f66-49fa-a20f-e7685b9565e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "1c07fb23-ced7-48f9-bf0a-e0df233cd7a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash" },
                values: new object[] { "091be5bf-9d58-40e6-98a8-e82859894571", "my@email.com", "AQAAAAEAACcQAAAAECBA6mt3xGNgyLjwyRhhtI3PI2IBKsm00Y3bAJfjdVrgT0++e45OV5Vh4SLTLPDHEQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2020, 2, 8, 6, 13, 50, 97, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2020, 2, 8, 6, 13, 50, 96, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2020, 2, 8, 6, 13, 50, 97, DateTimeKind.Utc).AddTicks(2218));
        }
    }
}
