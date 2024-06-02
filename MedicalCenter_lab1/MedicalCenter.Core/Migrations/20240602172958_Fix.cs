using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalCenter.Core.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1e2a6c95-afda-40c2-950d-d72ccd996ccf"), "1e2a6c95-afda-40c2-950d-d72ccd996ccf", "Doctor", "DOCTOR" },
                    { new Guid("6466463a-908e-429c-851d-e1a6899d21f3"), "6466463a-908e-429c-851d-e1a6899d21f3", "Patient", "PATIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d"), 0, "Somewhere st, Ukraine", 28, "695d4762-8729-4e4e-b88c-d31de898fc73", new DateOnly(1995, 6, 21), "doctor@medcenter.babaka.page", true, "Бабаєва Вікторія Вікторівна", false, null, "DOCTOR@MEDCENTER.BABAKA.PAGE", "DOCTOR@MEDCENTER.BABAKA.PAGE", "AQAAAAIAAYagAAAAEFTfGNnjcmMh0sLOvi4Ve2MDhWwfI29DgF7UYi3SM8ZLE8HR8AZ/SWptISaXcF3L6w==", "0999997890", false, "/images/cracked raiden shogun.jpg", "8411183c-b6ae-4a7f-bb5e-c275379b1d6d", false, "doctor@medcenter.babaka.page" },
                    { new Guid("710ed46e-7876-4463-957a-68c7228d37a4"), 0, "SomewhereElse st, Ukraine", 25, "0e6c24fc-208e-4330-b272-1bcb8b2aa1f8", new DateOnly(1998, 6, 21), "doctor@medcenter.kin.page", true, "Коновал Анастасія Андріївна", false, null, "DOCTOR@MEDCENTER.KIN.PAGE", "DOCTOR@MEDCENTER.KIN.PAGE", "AQAAAAIAAYagAAAAEIIPtpwrgpJlJV+0B89h/hNLR9WE+nB966vb4y8zmbqiejVr9BcbbEZ8e64Gu8wobg==", "0966665432", false, "/images/cracked yae miko.jpg", "74320bdb-2895-4024-ad0c-f4878abac44e", false, "doctor@medcenter.kin.page" },
                    { new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"), 0, "Somewhere st, Ukraine", 28, "5da28c58-8cb8-4ea9-b35e-93d48e9abb0b", new DateOnly(1995, 6, 21), "patient@medcenter.babaka.page", true, "Бабаєв Віктор Вікторієвич", false, null, "PATIENT@MEDCENTER.BABAKA.PAGE", "PATIENT@MEDCENTER.BABAKA.PAGE", "AQAAAAIAAYagAAAAEGED3PNg9A66zNhkCqWfecS2bqd9K+RKt75IDsDIe5BK/7HLoXDGDYv+Y/GrOE8H5w==", "0988885340", false, "/images/Viktor.jpg", "45dc7be0-f44c-47f5-ad71-f6ca5775806c", false, "patient@medcenter.babaka.page" },
                    { new Guid("f2450e15-75a9-40b7-8f35-28da9c8c5cd5"), 0, "SomewhereElse st, Ukraine", 25, "beb91beb-42bd-4687-aae4-36439ca10885", new DateOnly(1998, 6, 21), "patient@medcenter.kin.page", true, "Коновал Андрій Анастасійович", false, null, "PATIENT@MEDCENTER.KIN.PAGE", "PATIENT@MEDCENTER.KIN.PAGE", "AQAAAAIAAYagAAAAENZ47VfggFs+CX3TsLmFdUQ0xzeQQPEByWvPFoksIR1Wn2zb/3m78gIn81Pg+4QgZQ==", "0958880540", false, "/images/Andriy.jpg", "09f33b72-61f0-4f54-940d-6731ad793771", false, "patient@medcenter.kin.page" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "DateTime", "DoctorId", "PatientId", "Type" },
                values: new object[,]
                {
                    { new Guid("32abdb5d-317f-4a4c-b916-867548678747"), new DateTime(2024, 6, 3, 20, 29, 56, 819, DateTimeKind.Local).AddTicks(7933), new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d"), new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"), "Проходження медогляду" },
                    { new Guid("5fafaaf5-1f33-4fb2-bcfc-3fe953a000e2"), new DateTime(2024, 6, 4, 20, 29, 56, 819, DateTimeKind.Local).AddTicks(8059), new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d"), new Guid("f2450e15-75a9-40b7-8f35-28da9c8c5cd5"), "Біль у горлі" },
                    { new Guid("789949da-2418-4932-9b7a-fc6b24b4df5b"), new DateTime(2024, 6, 3, 1, 29, 56, 819, DateTimeKind.Local).AddTicks(8073), new Guid("710ed46e-7876-4463-957a-68c7228d37a4"), new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"), "Виписка з лікарняного" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1e2a6c95-afda-40c2-950d-d72ccd996ccf"), new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d") },
                    { new Guid("1e2a6c95-afda-40c2-950d-d72ccd996ccf"), new Guid("710ed46e-7876-4463-957a-68c7228d37a4") },
                    { new Guid("6466463a-908e-429c-851d-e1a6899d21f3"), new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f") },
                    { new Guid("6466463a-908e-429c-851d-e1a6899d21f3"), new Guid("f2450e15-75a9-40b7-8f35-28da9c8c5cd5") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedOn", "DoctorId", "MainText", "PatientId", "Title" },
                values: new object[,]
                {
                    { new Guid("440b80a2-8eeb-4892-8eef-5f4b8458a613"), new DateTime(2024, 6, 2, 20, 29, 56, 819, DateTimeKind.Local).AddTicks(8436), new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d"), "Жахливе ставлення, відмовила приймати мене без черги, а мені було просто спитать", new Guid("f2450e15-75a9-40b7-8f35-28da9c8c5cd5"), "Немає слів" },
                    { new Guid("615d47d2-b83d-4e0b-aa25-a3d3673cf5de"), new DateTime(2024, 6, 2, 20, 29, 56, 819, DateTimeKind.Local).AddTicks(8452), new Guid("710ed46e-7876-4463-957a-68c7228d37a4"), "Назва коментаря вже все сказала за мене", new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"), "Найкраща сімейна лікарка" },
                    { new Guid("8e635fd1-21b3-48a2-a111-4a3b57f4d7a5"), new DateTime(2024, 6, 2, 20, 29, 56, 819, DateTimeKind.Local).AddTicks(8404), new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d"), "Чудова лікарка, виписала направлення на безкоштовні аналізи, експіріенс десять з десяти", new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"), "Все супер" }
                });

            migrationBuilder.InsertData(
                table: "Diagnosis",
                columns: new[] { "Id", "Date", "PatientId", "Perscription", "diagnosis" },
                values: new object[,]
                {
                    { new Guid("69b2e816-8750-411c-8799-583ce196124d"), new DateOnly(2024, 5, 8), new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"), "Адаптол 1 таб. 2 р. на день, Гліцисед 1 таб. 3 р. на день, сон мінімум 10 годин на день", "Нервовий зрив" },
                    { new Guid("9425e5e6-29a2-4f0f-b7f9-2d312571b0c9"), new DateOnly(2023, 8, 18), new Guid("f2450e15-75a9-40b7-8f35-28da9c8c5cd5"), "Чай з малиною 4 р. на день, постільний режим", "Ларингіт" },
                    { new Guid("ff0b3c6f-fd99-4aa8-874c-7bc66e22f8dd"), new DateOnly(2023, 4, 29), new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"), "Чай з малиною 4 р. на день, постільний режим", "Гострий бронхіт" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("32abdb5d-317f-4a4c-b916-867548678747"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("5fafaaf5-1f33-4fb2-bcfc-3fe953a000e2"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("789949da-2418-4932-9b7a-fc6b24b4df5b"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1e2a6c95-afda-40c2-950d-d72ccd996ccf"), new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1e2a6c95-afda-40c2-950d-d72ccd996ccf"), new Guid("710ed46e-7876-4463-957a-68c7228d37a4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6466463a-908e-429c-851d-e1a6899d21f3"), new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6466463a-908e-429c-851d-e1a6899d21f3"), new Guid("f2450e15-75a9-40b7-8f35-28da9c8c5cd5") });

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("440b80a2-8eeb-4892-8eef-5f4b8458a613"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("615d47d2-b83d-4e0b-aa25-a3d3673cf5de"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("8e635fd1-21b3-48a2-a111-4a3b57f4d7a5"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("69b2e816-8750-411c-8799-583ce196124d"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("9425e5e6-29a2-4f0f-b7f9-2d312571b0c9"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("ff0b3c6f-fd99-4aa8-874c-7bc66e22f8dd"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e2a6c95-afda-40c2-950d-d72ccd996ccf"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6466463a-908e-429c-851d-e1a6899d21f3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("710ed46e-7876-4463-957a-68c7228d37a4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2450e15-75a9-40b7-8f35-28da9c8c5cd5"));

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
    }
}
