using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspnetIdentity.Migrations
{
    /// <inheritdoc />
    public partial class InitialUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5f70f647-c998-4356-a43c-9c8de54e6b88", null, "admin", "Admin" },
                    { "ca013a26-720d-4612-be0c-dfb19928c20c", null, "user", "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "75e87af7-b58e-4d09-82d4-8eb717490d18", 0, "308fa60b-9d62-49c2-9278-dd6b0d8c5791", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEKxduiu/GeJAhth9KGDadu4VjIHI19jQdcDx2AumyIijcAO7mr0NdRz1tkzsHwrnAw==", null, false, "4f9bf30e-9a91-4b30-af24-c9b34ab9ffbd", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5f70f647-c998-4356-a43c-9c8de54e6b88", "75e87af7-b58e-4d09-82d4-8eb717490d18" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca013a26-720d-4612-be0c-dfb19928c20c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5f70f647-c998-4356-a43c-9c8de54e6b88", "75e87af7-b58e-4d09-82d4-8eb717490d18" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f70f647-c998-4356-a43c-9c8de54e6b88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75e87af7-b58e-4d09-82d4-8eb717490d18");

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
    }
}
