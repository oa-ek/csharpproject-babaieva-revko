using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalCenter.Core.Migrations
{
    /// <inheritdoc />
    public partial class Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("28ffd9e3-dfaf-4894-952f-239f0aec10ed"), "28ffd9e3-dfaf-4894-952f-239f0aec10ed", "Admin", "ADMIN" },
                    { new Guid("4968d747-e70f-42c5-a683-afc83da968ab"), "4968d747-e70f-42c5-a683-afc83da968ab", "Patient", "PATIENT" },
                    { new Guid("be18057e-0c85-4a26-a622-38c77cd1617e"), "be18057e-0c85-4a26-a622-38c77cd1617e", "Doctor", "DOCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("27e4ca5a-1242-4f47-86a1-6437052b6700"), 0, "SomewhereElse st, Ukraine", 25, "56ce4f52-bb31-4b93-b0f9-214cc78637ac", new DateOnly(1998, 6, 21), "doctor@medcenter.kin.page", true, "Коновал Анастасія Андріївна", false, null, "DOCTOR@MEDCENTER.KIN.PAGE", "DOCTOR@MEDCENTER.KIN.PAGE", "AQAAAAIAAYagAAAAEHYDupy59tuXIgEZhird1IkUb2KZ5qMDDG+ALE/suEENcugJGnUoMnbyHV8KeIos8w==", "0966665432", false, "/images/cracked yae miko.jpg", "84b39260-b1c9-4438-bec0-000bdfded724", false, "doctor@medcenter.kin.page" },
                    { new Guid("90aa2d7f-5593-4171-867e-d89c236f3ce5"), 0, "SomewhereElse st, Ukraine", 25, "33df26a1-a114-4444-9c00-43467ec8fe6f", new DateOnly(1998, 6, 21), "patient@medcenter.kin.page", true, "Коновал Андрій Анастасійович", false, null, "PATIENT@MEDCENTER.KIN.PAGE", "PATIENT@MEDCENTER.KIN.PAGE", "AQAAAAIAAYagAAAAEFLjlg7OZKv5ceXFfWoK6EaHMkw6JN1plFhOovEVs+tB9rQo141enQyTiArK04M4/Q==", "0958880540", false, "/images/Andriy.jpg", "fa00471a-a3fb-40d2-837d-745d9dc7f7f4", false, "patient@medcenter.kin.page" },
                    { new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"), 0, "Somewhere st, Ukraine", 28, "c0ad8b6d-9634-4216-bd20-cba1a19d4975", new DateOnly(1995, 6, 21), "patient@medcenter.babaka.page", true, "Бабаєв Віктор Вікторієвич", false, null, "PATIENT@MEDCENTER.BABAKA.PAGE", "PATIENT@MEDCENTER.BABAKA.PAGE", "AQAAAAIAAYagAAAAEBupe0vtA6a/DaPOsKrH6X0vwUOxaHgrHrDyGnT+ZURLuuQiaOOSvS5JiDzvmp80oQ==", "0988885340", false, "/images/Viktor.jpg", "888c65f5-8493-45c2-8797-fa22ad4f72fe", false, "patient@medcenter.babaka.page" },
                    { new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"), 0, "Somewhere st, Ukraine", 28, "c00e1fd0-bc96-48c1-960b-040db8f71a57", new DateOnly(1995, 6, 21), "doctor@medcenter.babaka.page", true, "Бабаєва Вікторія Вікторівна", false, null, "DOCTOR@MEDCENTER.BABAKA.PAGE", "DOCTOR@MEDCENTER.BABAKA.PAGE", "AQAAAAIAAYagAAAAEHr2GevPVyPlPJ6bBLVZ2G4jskRMhFN5aO0WXkWEyZj17FbtiJKqPcR7B85cMSpZVg==", "0999997890", false, "/images/cracked raiden shogun.jpg", "182145e6-6bd7-48e6-9264-6823b752adf8", false, "doctor@medcenter.babaka.page" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "DateTime", "DoctorId", "PatientId", "Type" },
                values: new object[,]
                {
                    { new Guid("29d85ba2-8b8f-47c1-873f-4577ccea0fd1"), new DateTime(2024, 6, 4, 20, 16, 41, 274, DateTimeKind.Local).AddTicks(7803), new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"), new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"), "Проходження медогляду" },
                    { new Guid("ab607105-d684-4782-9afb-ad3584aab03a"), new DateTime(2024, 6, 5, 20, 16, 41, 274, DateTimeKind.Local).AddTicks(7938), new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"), new Guid("90aa2d7f-5593-4171-867e-d89c236f3ce5"), "Біль у горлі" },
                    { new Guid("c945eec5-aeb8-48ef-b8a9-a877fe4dc27d"), new DateTime(2024, 6, 4, 1, 16, 41, 274, DateTimeKind.Local).AddTicks(7947), new Guid("27e4ca5a-1242-4f47-86a1-6437052b6700"), new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"), "Виписка з лікарняного" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("be18057e-0c85-4a26-a622-38c77cd1617e"), new Guid("27e4ca5a-1242-4f47-86a1-6437052b6700") },
                    { new Guid("4968d747-e70f-42c5-a683-afc83da968ab"), new Guid("90aa2d7f-5593-4171-867e-d89c236f3ce5") },
                    { new Guid("4968d747-e70f-42c5-a683-afc83da968ab"), new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9") },
                    { new Guid("28ffd9e3-dfaf-4894-952f-239f0aec10ed"), new Guid("f762165f-7813-43b5-a47f-3ac8703853cb") },
                    { new Guid("be18057e-0c85-4a26-a622-38c77cd1617e"), new Guid("f762165f-7813-43b5-a47f-3ac8703853cb") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedOn", "DoctorId", "MainText", "PatientId", "Title" },
                values: new object[,]
                {
                    { new Guid("111f2a8f-e036-4884-9d36-9457bc534526"), new DateTime(2024, 6, 3, 20, 16, 41, 274, DateTimeKind.Local).AddTicks(8221), new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"), "Чудова лікарка, виписала направлення на безкоштовні аналізи, експіріенс десять з десяти", new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"), "Все супер" },
                    { new Guid("21c23937-d567-45ac-b302-7c7f5da93cb7"), new DateTime(2024, 6, 3, 20, 16, 41, 274, DateTimeKind.Local).AddTicks(8266), new Guid("27e4ca5a-1242-4f47-86a1-6437052b6700"), "Назва коментаря вже все сказала за мене", new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"), "Найкраща сімейна лікарка" },
                    { new Guid("a8c13a79-ea4b-46ff-80ef-6e61da9e5eb7"), new DateTime(2024, 6, 3, 20, 16, 41, 274, DateTimeKind.Local).AddTicks(8252), new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"), "Жахливе ставлення, відмовила приймати мене без черги, а мені було просто спитать", new Guid("90aa2d7f-5593-4171-867e-d89c236f3ce5"), "Немає слів" }
                });

            migrationBuilder.InsertData(
                table: "Diagnosis",
                columns: new[] { "Id", "Date", "PatientId", "Perscription", "diagnosis" },
                values: new object[,]
                {
                    { new Guid("23c3bac6-2259-4b11-aa6e-2d7b95517f30"), new DateOnly(2023, 4, 29), new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"), "Чай з малиною 4 р. на день, постільний режим", "Гострий бронхіт" },
                    { new Guid("50fd0fad-24f4-454c-97fd-dcec971ddacf"), new DateOnly(2023, 8, 18), new Guid("90aa2d7f-5593-4171-867e-d89c236f3ce5"), "Чай з малиною 4 р. на день, постільний режим", "Ларингіт" },
                    { new Guid("d4db9cae-fb72-4063-bdaf-5f2d12d91e77"), new DateOnly(2024, 5, 8), new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"), "Адаптол 1 таб. 2 р. на день, Гліцисед 1 таб. 3 р. на день, сон мінімум 10 годин на день", "Нервовий зрив" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("29d85ba2-8b8f-47c1-873f-4577ccea0fd1"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ab607105-d684-4782-9afb-ad3584aab03a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c945eec5-aeb8-48ef-b8a9-a877fe4dc27d"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("be18057e-0c85-4a26-a622-38c77cd1617e"), new Guid("27e4ca5a-1242-4f47-86a1-6437052b6700") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4968d747-e70f-42c5-a683-afc83da968ab"), new Guid("90aa2d7f-5593-4171-867e-d89c236f3ce5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4968d747-e70f-42c5-a683-afc83da968ab"), new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("28ffd9e3-dfaf-4894-952f-239f0aec10ed"), new Guid("f762165f-7813-43b5-a47f-3ac8703853cb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("be18057e-0c85-4a26-a622-38c77cd1617e"), new Guid("f762165f-7813-43b5-a47f-3ac8703853cb") });

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("111f2a8f-e036-4884-9d36-9457bc534526"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("21c23937-d567-45ac-b302-7c7f5da93cb7"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a8c13a79-ea4b-46ff-80ef-6e61da9e5eb7"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("23c3bac6-2259-4b11-aa6e-2d7b95517f30"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("50fd0fad-24f4-454c-97fd-dcec971ddacf"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("d4db9cae-fb72-4063-bdaf-5f2d12d91e77"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("28ffd9e3-dfaf-4894-952f-239f0aec10ed"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4968d747-e70f-42c5-a683-afc83da968ab"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("be18057e-0c85-4a26-a622-38c77cd1617e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("27e4ca5a-1242-4f47-86a1-6437052b6700"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("90aa2d7f-5593-4171-867e-d89c236f3ce5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"));

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
    }
}
