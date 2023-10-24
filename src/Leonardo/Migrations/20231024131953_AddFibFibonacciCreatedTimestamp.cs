using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leonardo.Migrations
{
    /// <inheritdoc />
    public partial class AddFibFibonacciCreatedTimestamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FIB_CreatedTimestamp",
                schema: "sch_fib",
                table: "T_Fibonacci",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FIB_CreatedTimestamp",
                schema: "sch_fib",
                table: "T_Fibonacci");
        }
    }
}
