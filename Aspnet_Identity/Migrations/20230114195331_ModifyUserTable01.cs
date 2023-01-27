using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspnetIdentity.Migrations
{
    /// <inheritdoc />
    public partial class ModifyUserTable01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f560d3e6-e085-4e8a-8a9a-16123b079483");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f87c909-9eb7-416a-884a-224e737731b3", "a6f5ce58-db83-433c-9863-621a90180540" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f87c909-9eb7-416a-884a-224e737731b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6f5ce58-db83-433c-9863-621a90180540");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "3f87c909-9eb7-416a-884a-224e737731b3", null, "admin", null },
                    { "f560d3e6-e085-4e8a-8a9a-16123b079483", null, "user", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a6f5ce58-db83-433c-9863-621a90180540", 0, "990670bc-e458-43a7-aa20-4d92a1d1f29d", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEAP/jCYilUEvJdKF4KtoOj69TwNAS0Xx8H2ovWprGodUhb/wphXdAl+jWPHm22oT9A==", null, false, "5f51f4cd-1a9b-420d-a2cc-9a7672fbd8f5", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3f87c909-9eb7-416a-884a-224e737731b3", "a6f5ce58-db83-433c-9863-621a90180540" });
        }
    }
}
