using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulse.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class RevertFixForAuthSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c40edf-7bf2-47de-b54a-f8f980553fc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "456bce7a-af26-47a8-979f-8625a3e979b3", "AQAAAAIAAYagAAAAEDvbLaB2j8b+dvIsDgIOk+NYWhYI+wBbNFzSrtOpPwFR5ThcAAn8okewiX/fvbE/3w==", "2e843b30-ffe0-4ef6-b6c4-298a3a61b987" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c40edf-7bf2-47de-b54a-f8f980553fc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f9a7f31-f068-490c-a991-481466c94c8d", "AQAAAAIAAYagAAAAEH+1sqwdqeYu6TpV+oKyIwVfjTIt6+YZJrzS5U0V2mN5D14nJIbCrK7lQ+V8mJ6uNg==", "b43fdc0c-1729-454e-b1a7-17a22e4caecf" });
        }
    }
}
