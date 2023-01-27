using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspnetIdentity.Migrations
{
    /// <inheritdoc />
    public partial class Modify03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d38e4ad-35ad-46b2-9f7f-5b82783438b0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1b634101-81a4-4000-b2c1-444927484fb7", "7c5617ed-25c7-4641-916a-ee602c28028d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b634101-81a4-4000-b2c1-444927484fb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c5617ed-25c7-4641-916a-ee602c28028d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e03ec4b0-64a1-4c6e-b5b7-552696bd43a3", null, "user", "User" },
                    { "eef34d23-7eef-4999-939f-0824d2b8eb7c", null, "admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8c0ed90b-6e5d-42a0-8133-50d897dd323d", 0, "3e48a747-bd17-486b-a295-01be8c888fd7", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEH1Wb6pLFfqoN469el5GQdjoTr81IvKJdJFhPOKT4hCh8QULm/+sXIGZyrJLvJ8sQA==", null, false, "a5fea503-7c36-4732-8b74-dc429fafc15d", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eef34d23-7eef-4999-939f-0824d2b8eb7c", "8c0ed90b-6e5d-42a0-8133-50d897dd323d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e03ec4b0-64a1-4c6e-b5b7-552696bd43a3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eef34d23-7eef-4999-939f-0824d2b8eb7c", "8c0ed90b-6e5d-42a0-8133-50d897dd323d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eef34d23-7eef-4999-939f-0824d2b8eb7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0ed90b-6e5d-42a0-8133-50d897dd323d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b634101-81a4-4000-b2c1-444927484fb7", null, "admin", null },
                    { "8d38e4ad-35ad-46b2-9f7f-5b82783438b0", null, "user", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7c5617ed-25c7-4641-916a-ee602c28028d", 0, "8f9cb686-8e0d-4347-87e2-777098b9f2a9", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEKIICOLIzove5fEA16KGu0KDB+GhJqh2wyEz0qnwgfjQhFpdKhNGG38nqWFJoBzw/g==", null, false, "2409f9b4-1c87-47ed-876d-7c8410199e00", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1b634101-81a4-4000-b2c1-444927484fb7", "7c5617ed-25c7-4641-916a-ee602c28028d" });
        }
    }
}
