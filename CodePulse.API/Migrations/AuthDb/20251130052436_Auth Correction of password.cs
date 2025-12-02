using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulse.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class AuthCorrectionofpassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c40edf-7bf2-47de-b54a-f8f980553fc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efd66de2-e033-42c7-9df6-1f90df19b235", "AQAAAAIAAYagAAAAEH+1sqwdqeYu6TpV+oKyIwVfjTIt6+YZJrzS5U0V2mN5D14nJIbCrK7lQ+V8mJ6uNg==", "15e8f00f-d775-4376-84c9-a2679ba5e851" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c40edf-7bf2-47de-b54a-f8f980553fc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cc84b65-b24c-4c41-b03d-abe96435faa0", "AQAAAAIAAYagAAAAEOoSLGhYjiTm6WiJ/iKbeIwdHO6+1i/5+R1huktZ5KMSivwCkIGcfCh1UzprcolMrQ==", "94ef1274-ea68-4c3a-80e4-bccedbd978aa" });
        }
    }
}
