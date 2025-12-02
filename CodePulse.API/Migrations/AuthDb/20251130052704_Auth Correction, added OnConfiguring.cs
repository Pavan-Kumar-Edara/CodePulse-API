using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulse.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class AuthCorrectionaddedOnConfiguring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c40edf-7bf2-47de-b54a-f8f980553fc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fac27c47-d6e7-4bd5-9da0-f042e6cec110", "AQAAAAIAAYagAAAAEA6ubJN3nzfqo6OX5nYZPFW9yK7MRReSir7NCFDo+KtFzK4YKDAvU7L5gBOryXTjvA==", "f3a0fc10-3fa3-41fb-b69f-678a4cbf3424" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c40edf-7bf2-47de-b54a-f8f980553fc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efd66de2-e033-42c7-9df6-1f90df19b235", "AQAAAAIAAYagAAAAEH+1sqwdqeYu6TpV+oKyIwVfjTIt6+YZJrzS5U0V2mN5D14nJIbCrK7lQ+V8mJ6uNg==", "15e8f00f-d775-4376-84c9-a2679ba5e851" });
        }
    }
}
