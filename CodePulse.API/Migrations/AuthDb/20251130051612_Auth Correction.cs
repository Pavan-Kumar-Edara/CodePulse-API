using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulse.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class AuthCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c40edf-7bf2-47de-b54a-f8f980553fc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cc84b65-b24c-4c41-b03d-abe96435faa0", "AQAAAAIAAYagAAAAEOoSLGhYjiTm6WiJ/iKbeIwdHO6+1i/5+R1huktZ5KMSivwCkIGcfCh1UzprcolMrQ==", "94ef1274-ea68-4c3a-80e4-bccedbd978aa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c40edf-7bf2-47de-b54a-f8f980553fc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "456bce7a-af26-47a8-979f-8625a3e979b3", "AQAAAAIAAYagAAAAEDvbLaB2j8b+dvIsDgIOk+NYWhYI+wBbNFzSrtOpPwFR5ThcAAn8okewiX/fvbE/3w==", "2e843b30-ffe0-4ef6-b6c4-298a3a61b987" });
        }
    }
}
