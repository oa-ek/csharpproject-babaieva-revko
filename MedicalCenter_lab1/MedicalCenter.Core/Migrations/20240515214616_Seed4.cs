using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalCenter.Core.Migrations
{
    /// <inheritdoc />
    public partial class Seed4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("696c4823-4558-46b6-a7dc-05e645c8597a"), "696c4823-4558-46b6-a7dc-05e645c8597a", "Patient", "PATIENT" },
                    { new Guid("a4ff3429-2ace-4453-9a2e-14df1485b082"), "a4ff3429-2ace-4453-9a2e-14df1485b082", "Doctor", "DOCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6aa82248-9b69-4613-b368-237677e16c22"), 0, "Somewhere st, Ukraine", 28, "0efe5350-252b-41e3-879a-da051ede028d", new DateOnly(1995, 6, 21), "patient@medcenter.babaka.page", true, "Бабаєв Віктор Вікторієвич", false, null, "PATIENT@MEDCENTER.BABAKA.PAGE", "PATIENT@MEDCENTER.BABAKA.PAGE", "AQAAAAIAAYagAAAAEFmHPg43vQTT/2P0gY4VPDLIJFeIYBqdKqNjdmzySal8bBrsX+hIorp+rYrirrpHiw==", null, false, "/images/Viktor.jpg", "319288c8-5f7b-411d-b564-9994f00ac83b", false, "patient@medcenter.babaka.page" },
                    { new Guid("85666de8-8ff5-4e13-b5de-4caa7172c858"), 0, "SomewhereElse st, Ukraine", 25, "1a17e79e-96b1-4d3b-bc65-87a054bc06f7", new DateOnly(1998, 6, 21), "patient@medcenter.kin.page", true, "Коновал Андрій Анастасійович", false, null, "PATIENT@MEDCENTER.KIN.PAGE", "PATIENT@MEDCENTER.KIN.PAGE", "AQAAAAIAAYagAAAAEKFk2SbJsyvjmBqe9HC35vE+rJ8pnRT3iR/Fm4yM0ZgsfDEDJvCPiZWv2LhyHrVDKw==", null, false, "/images/Andriy.jpg", "e53d2e4d-c29e-4b33-935d-4103dd217489", false, "patient@medcenter.kin.page" },
                    { new Guid("c6dd4402-f46e-4f03-af1c-92cf452020fd"), 0, "Somewhere st, Ukraine", 28, "3130c2ab-1709-4a7f-9fe1-473947553e22", new DateOnly(1995, 6, 21), "doctor@medcenter.babaka.page", true, "Бабаєва Вікторія Вікторівна", false, null, "DOCTOR@MEDCENTER.BABAKA.PAGE", "DOCTOR@MEDCENTER.BABAKA.PAGE", "AQAAAAIAAYagAAAAEBeFeAfeRUjSuTqBXI2DPgtf++J+3RnSpoxJxvHcHy392Drzw6KMNdAUNtdoJRjV2g==", null, false, "/images/cracked raiden shogun.jpg", "1a696673-1a25-4b05-805a-358d1df0246f", false, "doctor@medcenter.babaka.page" },
                    { new Guid("db0e0bb3-c0df-4adc-a7dc-96c40af97335"), 0, "SomewhereElse st, Ukraine", 25, "c0a61a1c-099e-4218-ae18-195e36603b7f", new DateOnly(1998, 6, 21), "doctor@medcenter.kin.page", true, "Коновал Анастасія Андріївна", false, null, "DOCTOR@MEDCENTER.KIN.PAGE", "DOCTOR@MEDCENTER.KIN.PAGE", null, null, false, "/images/cracked yae miko.jpg", "047e7c4f-eaba-42c3-bf3e-55da6fd27d21", false, "doctor@medcenter.kin.page" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "DateTime", "DoctorId", "PatientId", "Type" },
                values: new object[,]
                {
                    { new Guid("0832572d-7027-48bb-a2df-5f36b537a576"), new DateTime(2024, 5, 17, 0, 46, 16, 182, DateTimeKind.Local).AddTicks(6328), new Guid("c6dd4402-f46e-4f03-af1c-92cf452020fd"), new Guid("6aa82248-9b69-4613-b368-237677e16c22"), "Проходження медогляду" },
                    { new Guid("cd4dec87-cfa8-4d5d-b758-3659461a61f8"), new DateTime(2024, 5, 18, 0, 46, 16, 182, DateTimeKind.Local).AddTicks(6425), new Guid("c6dd4402-f46e-4f03-af1c-92cf452020fd"), new Guid("85666de8-8ff5-4e13-b5de-4caa7172c858"), "Біль у горлі" },
                    { new Guid("e8f35195-f731-49ab-b215-a67d80c252a8"), new DateTime(2024, 5, 16, 5, 46, 16, 182, DateTimeKind.Local).AddTicks(6441), new Guid("db0e0bb3-c0df-4adc-a7dc-96c40af97335"), new Guid("6aa82248-9b69-4613-b368-237677e16c22"), "Виписка з лікарняного" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("696c4823-4558-46b6-a7dc-05e645c8597a"), new Guid("6aa82248-9b69-4613-b368-237677e16c22") },
                    { new Guid("696c4823-4558-46b6-a7dc-05e645c8597a"), new Guid("85666de8-8ff5-4e13-b5de-4caa7172c858") },
                    { new Guid("a4ff3429-2ace-4453-9a2e-14df1485b082"), new Guid("c6dd4402-f46e-4f03-af1c-92cf452020fd") },
                    { new Guid("a4ff3429-2ace-4453-9a2e-14df1485b082"), new Guid("db0e0bb3-c0df-4adc-a7dc-96c40af97335") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedOn", "DoctorId", "MainText", "PatientId", "Title" },
                values: new object[,]
                {
                    { new Guid("4315fe48-8127-4478-8812-d81629b15ffc"), new DateTime(2024, 5, 16, 0, 46, 16, 182, DateTimeKind.Local).AddTicks(6719), new Guid("db0e0bb3-c0df-4adc-a7dc-96c40af97335"), "Назва коментаря вже все сказала за мене", new Guid("6aa82248-9b69-4613-b368-237677e16c22"), "Найкраща сімейна лікарка" },
                    { new Guid("585a0fa3-9115-428f-84c4-473d412f721f"), new DateTime(2024, 5, 16, 0, 46, 16, 182, DateTimeKind.Local).AddTicks(6708), new Guid("c6dd4402-f46e-4f03-af1c-92cf452020fd"), "Жахливе ставлення, відмовила приймати мене без черги, а мені було просто спитать", new Guid("85666de8-8ff5-4e13-b5de-4caa7172c858"), "Немає слів" },
                    { new Guid("7b4069b9-904d-4d62-9790-05907bbb9e3b"), new DateTime(2024, 5, 16, 0, 46, 16, 182, DateTimeKind.Local).AddTicks(6695), new Guid("c6dd4402-f46e-4f03-af1c-92cf452020fd"), "Чудова лікарка, виписала направлення на безкоштовні аналізи, експіріенс десять з десяти", new Guid("6aa82248-9b69-4613-b368-237677e16c22"), "Все супер" }
                });

            migrationBuilder.InsertData(
                table: "Diagnosis",
                columns: new[] { "Id", "Date", "PatientId", "Perscription", "diagnosis" },
                values: new object[,]
                {
                    { new Guid("11739976-728b-4a43-90f2-567a965ee997"), new DateOnly(2024, 5, 8), new Guid("6aa82248-9b69-4613-b368-237677e16c22"), "Адаптол 1 таб. 2 р. на день, Гліцисед 1 таб. 3 р. на день, сон мінімум 10 годин на день", "Нервовий зрив" },
                    { new Guid("6e7806fe-fe1f-4b8f-9d1c-f316a785f38a"), new DateOnly(2023, 4, 29), new Guid("6aa82248-9b69-4613-b368-237677e16c22"), "Чай з малиною 4 р. на день, постільний режим", "Гострий бронхіт" },
                    { new Guid("c13165aa-0a1a-48fd-bf56-b4ea094a116a"), new DateOnly(2023, 8, 18), new Guid("85666de8-8ff5-4e13-b5de-4caa7172c858"), "Чай з малиною 4 р. на день, постільний режим", "Ларингіт" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0832572d-7027-48bb-a2df-5f36b537a576"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("cd4dec87-cfa8-4d5d-b758-3659461a61f8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e8f35195-f731-49ab-b215-a67d80c252a8"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("696c4823-4558-46b6-a7dc-05e645c8597a"), new Guid("6aa82248-9b69-4613-b368-237677e16c22") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("696c4823-4558-46b6-a7dc-05e645c8597a"), new Guid("85666de8-8ff5-4e13-b5de-4caa7172c858") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a4ff3429-2ace-4453-9a2e-14df1485b082"), new Guid("c6dd4402-f46e-4f03-af1c-92cf452020fd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a4ff3429-2ace-4453-9a2e-14df1485b082"), new Guid("db0e0bb3-c0df-4adc-a7dc-96c40af97335") });

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("4315fe48-8127-4478-8812-d81629b15ffc"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("585a0fa3-9115-428f-84c4-473d412f721f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("7b4069b9-904d-4d62-9790-05907bbb9e3b"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("11739976-728b-4a43-90f2-567a965ee997"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("6e7806fe-fe1f-4b8f-9d1c-f316a785f38a"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("c13165aa-0a1a-48fd-bf56-b4ea094a116a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("696c4823-4558-46b6-a7dc-05e645c8597a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a4ff3429-2ace-4453-9a2e-14df1485b082"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6aa82248-9b69-4613-b368-237677e16c22"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("85666de8-8ff5-4e13-b5de-4caa7172c858"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6dd4402-f46e-4f03-af1c-92cf452020fd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("db0e0bb3-c0df-4adc-a7dc-96c40af97335"));

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
    }
}
