using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalCenter.Core.Migrations
{
    /// <inheritdoc />
    public partial class Seed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("ab3be527-444f-4c5d-913e-45a7f30c2a64"), "ab3be527-444f-4c5d-913e-45a7f30c2a64", "Patient", "PATIENT" },
                    { new Guid("d2ca9abf-f933-414b-aed0-02b6abb4271b"), "d2ca9abf-f933-414b-aed0-02b6abb4271b", "Doctor", "DOCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1fd3e1c1-ccd3-4ceb-ab32-1f2be0073d90"), 0, "SomewhereElse st, Ukraine", 25, "35e4bd12-07ff-4dd9-9c04-b4feaa9dfcfc", new DateOnly(1998, 6, 21), "doctor@medcenter.kin.page", true, "Коновал Анастасія Андріївна", false, null, "DOCTOR@MEDCENTER.KIN.PAGE", "DOCTOR@MEDCENTER.KIN.PAGE", null, null, false, "/Entities/images/cracked yae miko.jpg", "0d015e08-23b7-4b4d-9010-0cb3d3fa42a1", false, "doctor@medcenter.kin.page" },
                    { new Guid("46d4ea5d-a17e-43b4-b1f9-8e371cee7f71"), 0, "Somewhere st, Ukraine", 28, "5b1393b3-65cc-449f-a146-18912aa3db9c", new DateOnly(1995, 6, 21), "doctor@medcenter.babaka.page", true, "Бабаєва Вікторія Вікторівна", false, null, "DOCTOR@MEDCENTER.BABAKA.PAGE", "DOCTOR@MEDCENTER.BABAKA.PAGE", "AQAAAAIAAYagAAAAENx07nw75V3BNhrph3wxi8S247D4kI1iZ6lZh8wXFWiYDFspYniOQ2oPZL2wg1WraA==", null, false, "/Entities/images/cracked raiden shogun.jpg", "2ee58bd8-aeef-4de2-bbcb-6d55eb290ad7", false, "doctor@medcenter.babaka.page" },
                    { new Guid("73ec8fa5-7d1e-4d05-8d94-fb08c1d7e113"), 0, "SomewhereElse st, Ukraine", 25, "9ced1b99-b853-42cd-9e93-35585d17efc9", new DateOnly(1998, 6, 21), "patient@medcenter.kin.page", true, "Коновал Андрій Анастасійович", false, null, "PATIENT@MEDCENTER.KIN.PAGE", "PATIENT@MEDCENTER.KIN.PAGE", "AQAAAAIAAYagAAAAEIlRkDG4IjFxvfBV1UXrj98qIZumA72ZJ1KwNkFKXShkwizyhe4v9WTLFssVNermnQ==", null, false, "/Entities/images/Andriy.jpg", "69c7bfad-0399-48e2-a2f6-eec3e883efbc", false, "patient@medcenter.kin.page" },
                    { new Guid("e9511a86-b644-4748-bfb2-f3feb796f4a9"), 0, "Somewhere st, Ukraine", 28, "1330b791-bdf6-479b-baf1-b28dfa243709", new DateOnly(1995, 6, 21), "patient@medcenter.babaka.page", true, "Бабаєв Віктор Вікторієвич", false, null, "PATIENT@MEDCENTER.BABAKA.PAGE", "PATIENT@MEDCENTER.BABAKA.PAGE", "AQAAAAIAAYagAAAAEMuc5tqb8s3/9TSNJpDfffZCvXUKWnoHYeGov+ARfY93d1UPZ6BUo8Lj5cxhv2XblA==", null, false, "/Entities/images/Viktor.jpg", "d5e21faf-2359-4b99-b6c2-4d3c723db004", false, "patient@medcenter.babaka.page" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "DateTime", "DoctorId", "PatientId", "Type" },
                values: new object[,]
                {
                    { new Guid("7465435d-0cad-456e-bcd2-0b713ab0c101"), new DateTime(2024, 5, 16, 5, 43, 58, 246, DateTimeKind.Local).AddTicks(6370), new Guid("1fd3e1c1-ccd3-4ceb-ab32-1f2be0073d90"), new Guid("e9511a86-b644-4748-bfb2-f3feb796f4a9"), "Виписка з лікарняного" },
                    { new Guid("d84d5411-2d2f-4782-a9e4-17fcd806e8cd"), new DateTime(2024, 5, 18, 0, 43, 58, 246, DateTimeKind.Local).AddTicks(6358), new Guid("46d4ea5d-a17e-43b4-b1f9-8e371cee7f71"), new Guid("73ec8fa5-7d1e-4d05-8d94-fb08c1d7e113"), "Біль у горлі" },
                    { new Guid("f2a7ee8e-78cb-49f9-b9c7-993643f8a1f1"), new DateTime(2024, 5, 17, 0, 43, 58, 246, DateTimeKind.Local).AddTicks(6219), new Guid("46d4ea5d-a17e-43b4-b1f9-8e371cee7f71"), new Guid("e9511a86-b644-4748-bfb2-f3feb796f4a9"), "Проходження медогляду" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d2ca9abf-f933-414b-aed0-02b6abb4271b"), new Guid("1fd3e1c1-ccd3-4ceb-ab32-1f2be0073d90") },
                    { new Guid("d2ca9abf-f933-414b-aed0-02b6abb4271b"), new Guid("46d4ea5d-a17e-43b4-b1f9-8e371cee7f71") },
                    { new Guid("ab3be527-444f-4c5d-913e-45a7f30c2a64"), new Guid("73ec8fa5-7d1e-4d05-8d94-fb08c1d7e113") },
                    { new Guid("ab3be527-444f-4c5d-913e-45a7f30c2a64"), new Guid("e9511a86-b644-4748-bfb2-f3feb796f4a9") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedOn", "DoctorId", "MainText", "PatientId", "Title" },
                values: new object[,]
                {
                    { new Guid("8ac8d060-cf35-4bcd-b56f-bd365bfa59d7"), new DateTime(2024, 5, 16, 0, 43, 58, 246, DateTimeKind.Local).AddTicks(6670), new Guid("1fd3e1c1-ccd3-4ceb-ab32-1f2be0073d90"), "Назва коментаря вже все сказала за мене", new Guid("e9511a86-b644-4748-bfb2-f3feb796f4a9"), "Найкраща сімейна лікарка" },
                    { new Guid("99b1657a-c286-40de-a618-a72a99035222"), new DateTime(2024, 5, 16, 0, 43, 58, 246, DateTimeKind.Local).AddTicks(6642), new Guid("46d4ea5d-a17e-43b4-b1f9-8e371cee7f71"), "Жахливе ставлення, відмовила приймати мене без черги, а мені було просто спитать", new Guid("73ec8fa5-7d1e-4d05-8d94-fb08c1d7e113"), "Немає слів" },
                    { new Guid("e47c25c5-48e5-4434-894f-b8893245c14b"), new DateTime(2024, 5, 16, 0, 43, 58, 246, DateTimeKind.Local).AddTicks(6564), new Guid("46d4ea5d-a17e-43b4-b1f9-8e371cee7f71"), "Чудова лікарка, виписала направлення на безкоштовні аналізи, експіріенс десять з десяти", new Guid("e9511a86-b644-4748-bfb2-f3feb796f4a9"), "Все супер" }
                });

            migrationBuilder.InsertData(
                table: "Diagnosis",
                columns: new[] { "Id", "Date", "PatientId", "Perscription", "diagnosis" },
                values: new object[,]
                {
                    { new Guid("2a04a9dc-1b1a-4b5d-bcb7-bb0f9cb1f594"), new DateOnly(2024, 5, 8), new Guid("e9511a86-b644-4748-bfb2-f3feb796f4a9"), "Адаптол 1 таб. 2 р. на день, Гліцисед 1 таб. 3 р. на день, сон мінімум 10 годин на день", "Нервовий зрив" },
                    { new Guid("478258e2-bb5d-4735-878e-4b0b9a25b442"), new DateOnly(2023, 4, 29), new Guid("e9511a86-b644-4748-bfb2-f3feb796f4a9"), "Чай з малиною 4 р. на день, постільний режим", "Гострий бронхіт" },
                    { new Guid("ff9d34cb-c63f-4921-b806-1ab146e09382"), new DateOnly(2023, 8, 18), new Guid("73ec8fa5-7d1e-4d05-8d94-fb08c1d7e113"), "Чай з малиною 4 р. на день, постільний режим", "Ларингіт" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7465435d-0cad-456e-bcd2-0b713ab0c101"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("d84d5411-2d2f-4782-a9e4-17fcd806e8cd"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f2a7ee8e-78cb-49f9-b9c7-993643f8a1f1"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d2ca9abf-f933-414b-aed0-02b6abb4271b"), new Guid("1fd3e1c1-ccd3-4ceb-ab32-1f2be0073d90") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d2ca9abf-f933-414b-aed0-02b6abb4271b"), new Guid("46d4ea5d-a17e-43b4-b1f9-8e371cee7f71") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ab3be527-444f-4c5d-913e-45a7f30c2a64"), new Guid("73ec8fa5-7d1e-4d05-8d94-fb08c1d7e113") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ab3be527-444f-4c5d-913e-45a7f30c2a64"), new Guid("e9511a86-b644-4748-bfb2-f3feb796f4a9") });

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("8ac8d060-cf35-4bcd-b56f-bd365bfa59d7"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("99b1657a-c286-40de-a618-a72a99035222"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("e47c25c5-48e5-4434-894f-b8893245c14b"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("2a04a9dc-1b1a-4b5d-bcb7-bb0f9cb1f594"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("478258e2-bb5d-4735-878e-4b0b9a25b442"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("ff9d34cb-c63f-4921-b806-1ab146e09382"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ab3be527-444f-4c5d-913e-45a7f30c2a64"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d2ca9abf-f933-414b-aed0-02b6abb4271b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1fd3e1c1-ccd3-4ceb-ab32-1f2be0073d90"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("46d4ea5d-a17e-43b4-b1f9-8e371cee7f71"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73ec8fa5-7d1e-4d05-8d94-fb08c1d7e113"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e9511a86-b644-4748-bfb2-f3feb796f4a9"));

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
    }
}
