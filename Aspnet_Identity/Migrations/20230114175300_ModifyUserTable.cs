using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspnetIdentity.Migrations
{
    /// <inheritdoc />
    public partial class ModifyUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "067f24d2-f56c-4a39-b23d-c7b2ddf68532", "b27103ed-dfc7-4bba-9dc8-2c7c1c382b3d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "067f24d2-f56c-4a39-b23d-c7b2ddf68532");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b27103ed-dfc7-4bba-9dc8-2c7c1c382b3d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f8c3b2ad-1f70-4702-8a66-b51a7414e3e2", null, "admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "da31f8b8-4859-4981-a3fb-68110ebfb2ba", 0, "6761d509-9727-421f-8e83-2c4ca07941d7", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEKZTctOzEVzb8wPb7f0na+S+CzVqoyNEVSXIg5yUMoX9OuYN6rDUMEnWMoguy0w0rQ==", null, false, "427a3bb1-fa69-4bdd-93bc-153960c3ede6", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f8c3b2ad-1f70-4702-8a66-b51a7414e3e2", "da31f8b8-4859-4981-a3fb-68110ebfb2ba" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8c3b2ad-1f70-4702-8a66-b51a7414e3e2", "da31f8b8-4859-4981-a3fb-68110ebfb2ba" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8c3b2ad-1f70-4702-8a66-b51a7414e3e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da31f8b8-4859-4981-a3fb-68110ebfb2ba");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "067f24d2-f56c-4a39-b23d-c7b2ddf68532", null, "admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b27103ed-dfc7-4bba-9dc8-2c7c1c382b3d", 0, "1464a48e-50b6-47d7-83c0-02f6e3cce5b7", "admin@admin.com", true, false, null, null, null, null, null, false, "6123740e-b16e-4a18-8def-c9e0eaa6dc71", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "067f24d2-f56c-4a39-b23d-c7b2ddf68532", "b27103ed-dfc7-4bba-9dc8-2c7c1c382b3d" });
        }
    }
}
