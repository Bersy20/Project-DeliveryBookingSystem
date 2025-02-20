﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryBookingServiceSystemAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    AdminEmail = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(6)", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Executives",
                columns: table => new
                {
                    ExecutiveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExecutiveName = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ExecutiveEmail = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(6)", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    ExecutiveStatus = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Executives", x => x.ExecutiveId);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ExecutiveId = table.Column<int>(type: "int", nullable: false),
                    DateTimeOfPickUp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeightOfPackage = table.Column<double>(type: "float", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(6)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryStatus = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Executives_ExecutiveId",
                        column: x => x.ExecutiveId,
                        principalTable: "Executives",
                        principalColumn: "ExecutiveId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "Address", "AdminEmail", "AdminName", "Age", "City", "Password", "Phone", "PinCode" },
                values: new object[] { 1, "No.61, Anna Nagar", "admin@gmail.com", "Admin", 32, "CHENNAI", "Admin", "9443354155", "600006" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Age", "City", "CustomerEmail", "CustomerName", "IsVerified", "Password", "Phone", "PinCode" },
                values: new object[] { 1000, "1/271, BTR Nagar, Sipcot", 22, "HOSUR", "bersy@gmail.com", "Bersy", true, "1234", "7598377137", "635126" });

            migrationBuilder.InsertData(
                table: "Executives",
                columns: new[] { "ExecutiveId", "Address", "Age", "City", "ExecutiveEmail", "ExecutiveName", "ExecutiveStatus", "IsVerified", "Password", "Phone", "PinCode" },
                values: new object[] { 100, "No.81, Annai Nagar", 22, "HOSUR", "arun@gmail.com", "Arun", "Available", true, "1234", "9943354155", "601206" });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ExecutiveId",
                table: "Bookings",
                column: "ExecutiveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Executives");
        }
    }
}
