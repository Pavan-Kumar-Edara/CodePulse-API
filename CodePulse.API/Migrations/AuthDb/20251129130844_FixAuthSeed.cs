using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulse.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class FixAuthSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c40edf-7bf2-47de-b54a-f8f980553fc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f9a7f31-f068-490c-a991-481466c94c8d", "AQAAAAIAAYagAAAAEH+1sqwdqeYu6TpV+oKyIwVfjTIt6+YZJrzS5U0V2mN5D14nJIbCrK7lQ+V8mJ6uNg==", "b43fdc0c-1729-454e-b1a7-17a22e4caecf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c40edf-7bf2-47de-b54a-f8f980553fc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ac17578-8b18-49af-90ad-7d8d4154cf78", "AQAAAAIAAYagAAAAEAFwIP3TD+qR/dXO5zuK8RsKVO1HcElB4qloNbtVIDS5V7s7bN4ow4BIJdp+oykE8g==", "bef4a2e1-0f5d-48ed-b482-2d16976c065f" });
        }
    }
}
