using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class editIdAprobe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33546e06-8719-4ad8-b88a-f271ae9d6ecs",
                column: "ConcurrencyStamp",
                value: "5aa630e0-fb18-4403-b74e-03fe7c9fe06c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "de85eeee-d662-4c65-bcb4-d366232d7148");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c62472e-4f66-49fa-a20f-e7685b9565e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ad8808f-07c1-469c-aee2-f888b5404f05", "AQAAAAEAACcQAAAAEDl/jXQmSdf0G8Gmf7UCNuw9GwhZL3iiwuiakvGJCJ01/AWE9xy471QwQr5NTaCw9g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f06fa67-997a-44e5-be5b-558c73d2604c", "AQAAAAEAACcQAAAAEAI67b8BWG993JVxjlJ1ULVj7RO981Q2f3TBhFAljCNS0FoXe69bTy1ost7ol6UsXg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4ab76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 23, 14, 25, 33, 821, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63da8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 23, 14, 25, 33, 821, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 23, 14, 25, 33, 821, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70af165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 23, 14, 25, 33, 821, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70af175a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 23, 14, 25, 33, 821, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf166a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 23, 14, 25, 33, 821, DateTimeKind.Utc).AddTicks(8173));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33546e06-8719-4ad8-b88a-f271ae9d6ecs",
                column: "ConcurrencyStamp",
                value: "68e3b8e8-5020-4197-a13e-81f38e06befe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "90d4e9f6-9a8c-44ab-b5db-1d346c56a71e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c62472e-4f66-49fa-a20f-e7685b9565e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92e4dcb2-59ab-4d95-9b83-95e22f6cec3b", "AQAAAAEAACcQAAAAEDQut+k6RT6mpASZTWEMt8rl730JoCq7SFKh0kRD8Ib5JZa4vdHL0aCXtf6UtbXnrQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "75f22fa7-4ffd-469e-b511-89ac0486349b", "AQAAAAEAACcQAAAAEB03ScobEkVXGZuSjZcQBG79bFVfjUokKp2n+4OBp2kKRHEpTjcLduqfAYITChlL9g==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4ab76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 23, 13, 43, 24, 223, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63da8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 23, 13, 43, 24, 223, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 23, 13, 43, 24, 222, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70af165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 23, 13, 43, 24, 223, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70af175a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 23, 13, 43, 24, 223, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf166a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 23, 13, 43, 24, 223, DateTimeKind.Utc).AddTicks(468));
        }
    }
}
