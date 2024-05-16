using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalCenter.Core.Migrations
{
    /// <inheritdoc />
    public partial class Seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5a306a1d-567c-4a76-8d66-524ed18449e7"), "5a306a1d-567c-4a76-8d66-524ed18449e7", "Patient", "PATIENT" },
                    { new Guid("aa7c5b15-2800-4d24-9671-1ce15262729b"), "aa7c5b15-2800-4d24-9671-1ce15262729b", "Doctor", "DOCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3d9e92e1-0b80-4313-bee2-19eb245fbf45"), 0, "Somewhere st, Ukraine", 28, "90cc67ae-2de2-43ff-bc58-e6416c81f27f", new DateOnly(1995, 6, 21), "doctor@medcenter.babaka.page", true, "Бабаєва Вікторія Вікторівна", false, null, "DOCTOR@MEDCENTER.BABAKA.PAGE", "DOCTOR@MEDCENTER.BABAKA.PAGE", "AQAAAAIAAYagAAAAEJjPyXQCoZJwXq93c6uvYcLHGeo2U4HIeMK/C/y8QTyHhCykFueFMTXADtCoFL9Msw==", null, false, "/Entities/images/cracked raiden shogun.jpg", "31e798b9-e0fb-464f-8772-4cea1336ed6a", false, "doctor@medcenter.babaka.page" },
                    { new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3"), 0, "Somewhere st, Ukraine", 28, "e52fbb4a-d3ee-4df4-850b-72a096e44f13", new DateOnly(1995, 6, 21), "patient@medcenter.babaka.page", true, "Бабаєв Віктор Вікторієвич", false, null, "PATIENT@MEDCENTER.BABAKA.PAGE", "PATIENT@MEDCENTER.BABAKA.PAGE", "AQAAAAIAAYagAAAAEB4bh6t+FyMeJGuSmCccMweyp4hLSJR96E/2Lnka4OFS8s8P703aQxVz/5ZmLM6dYg==", null, false, "/Entities/images/Viktor.jpg", "2f816470-f90f-402a-acf7-bb7d2643dc17", false, "patient@medcenter.babaka.page" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "DateTime", "DoctorId", "PatientId", "Type" },
                values: new object[,]
                {
                    { new Guid("6487b67f-b219-4647-bc9a-86b3c2225851"), new DateTime(2024, 5, 18, 0, 4, 40, 394, DateTimeKind.Local).AddTicks(2721), new Guid("3d9e92e1-0b80-4313-bee2-19eb245fbf45"), new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3"), "Біль у горлі" },
                    { new Guid("eba20ca4-6337-46e4-8760-c7f11c463474"), new DateTime(2024, 5, 17, 0, 4, 40, 394, DateTimeKind.Local).AddTicks(2611), new Guid("3d9e92e1-0b80-4313-bee2-19eb245fbf45"), new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3"), "Проходження медогляду" },
                    { new Guid("f29cdd1f-093c-4652-a1af-a007124a4286"), new DateTime(2024, 5, 16, 5, 4, 40, 394, DateTimeKind.Local).AddTicks(2730), new Guid("3d9e92e1-0b80-4313-bee2-19eb245fbf45"), new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3"), "Виписка з лікарняного" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("aa7c5b15-2800-4d24-9671-1ce15262729b"), new Guid("3d9e92e1-0b80-4313-bee2-19eb245fbf45") },
                    { new Guid("5a306a1d-567c-4a76-8d66-524ed18449e7"), new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedOn", "DoctorId", "MainText", "PatientId", "Title" },
                values: new object[,]
                {
                    { new Guid("33acf093-708a-4eea-b330-68ca2f7b629c"), new DateTime(2024, 5, 16, 0, 4, 40, 394, DateTimeKind.Local).AddTicks(3009), new Guid("3d9e92e1-0b80-4313-bee2-19eb245fbf45"), "Назва коментаря вже все сказала за мене", new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3"), "Найкраща сімейна лікарка" },
                    { new Guid("50f6bbfe-1a2d-41ec-8c61-8b2ddb5066a2"), new DateTime(2024, 5, 16, 0, 4, 40, 394, DateTimeKind.Local).AddTicks(2969), new Guid("3d9e92e1-0b80-4313-bee2-19eb245fbf45"), "Чудова лікарка, виписала направлення на безкоштовні аналізи, експіріенс десять з десяти", new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3"), "Все супер" },
                    { new Guid("adf337b7-a76a-4efa-824f-f40841c24e3d"), new DateTime(2024, 5, 16, 0, 4, 40, 394, DateTimeKind.Local).AddTicks(2990), new Guid("3d9e92e1-0b80-4313-bee2-19eb245fbf45"), "Жахливе ставлення, відмовила приймати мене без черги, а мені було просто спитать", new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3"), "Немає слів" }
                });

            migrationBuilder.InsertData(
                table: "Diagnosis",
                columns: new[] { "Id", "Date", "PatientId", "Perscription", "diagnosis" },
                values: new object[,]
                {
                    { new Guid("102e4aa0-cd24-4db1-b213-b9389aceeb2a"), new DateOnly(2023, 4, 29), new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3"), "Чай з малиною 4 р. на день, постільний режим", "Гострий бронхіт" },
                    { new Guid("1e88e934-63c5-43fe-836a-4c1f7ffccfdf"), new DateOnly(2023, 8, 18), new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3"), "Чай з малиною 4 р. на день, постільний режим", "Ларингіт" },
                    { new Guid("6a3b2046-b43e-4700-9a2b-a0fac742527b"), new DateOnly(2024, 5, 8), new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3"), "Адаптол 1 таб. 2 р. на день, Гліцисед 1 таб. 3 р. на день, сон мінімум 10 годин на день", "Нервовий зрив" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6487b67f-b219-4647-bc9a-86b3c2225851"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("eba20ca4-6337-46e4-8760-c7f11c463474"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f29cdd1f-093c-4652-a1af-a007124a4286"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("aa7c5b15-2800-4d24-9671-1ce15262729b"), new Guid("3d9e92e1-0b80-4313-bee2-19eb245fbf45") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5a306a1d-567c-4a76-8d66-524ed18449e7"), new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3") });

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("33acf093-708a-4eea-b330-68ca2f7b629c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("50f6bbfe-1a2d-41ec-8c61-8b2ddb5066a2"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("adf337b7-a76a-4efa-824f-f40841c24e3d"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("102e4aa0-cd24-4db1-b213-b9389aceeb2a"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("1e88e934-63c5-43fe-836a-4c1f7ffccfdf"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("6a3b2046-b43e-4700-9a2b-a0fac742527b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5a306a1d-567c-4a76-8d66-524ed18449e7"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("aa7c5b15-2800-4d24-9671-1ce15262729b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3d9e92e1-0b80-4313-bee2-19eb245fbf45"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("61f47dc6-6f69-43d7-94d0-3ba0eaf8cef3"));
        }
    }
}
