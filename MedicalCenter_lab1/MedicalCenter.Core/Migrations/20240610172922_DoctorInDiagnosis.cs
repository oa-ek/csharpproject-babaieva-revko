using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalCenter.Core.Migrations
{
    /// <inheritdoc />
    public partial class DoctorInDiagnosis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "Diagnosis",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3960e876-9cd4-4e01-87bd-f16acd4d011c"), "3960e876-9cd4-4e01-87bd-f16acd4d011c", "Doctor", "DOCTOR" },
                    { new Guid("74e2a366-df71-4512-bb15-e8a89be4efb0"), "74e2a366-df71-4512-bb15-e8a89be4efb0", "Admin", "ADMIN" },
                    { new Guid("db7da560-149f-485d-97fd-ec65542e633b"), "db7da560-149f-485d-97fd-ec65542e633b", "Patient", "PATIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("5aecbc3c-641d-401e-b337-28f78b2f18dc"), 0, "SomewhereElse st, Ukraine", 25, "ad26afd4-5b6d-4e75-86af-abd656c1489a", new DateOnly(1998, 6, 21), "doctor@medcenter.kin.page", true, "Коновал Анастасія Андріївна", false, null, "DOCTOR@MEDCENTER.KIN.PAGE", "DOCTOR@MEDCENTER.KIN.PAGE", "AQAAAAIAAYagAAAAECcua1pWAdGXB+hNj3qW229VOoTkIuFA3BhYwX5f8ErUH7Du+NpuwCWhR7TaYdGUdw==", "0966665432", false, "/images/cracked yae miko.jpg", "73ecb144-c0fc-413b-b91e-202880213b81", false, "doctor@medcenter.kin.page" },
                    { new Guid("8ad50974-05c5-4f5e-aed4-065d7a04a1c3"), 0, "SomewhereElse st, Ukraine", 25, "55087db3-faa8-4540-acbb-4e11b9909ef0", new DateOnly(1998, 6, 21), "patient@medcenter.kin.page", true, "Коновал Андрій Анастасійович", false, null, "PATIENT@MEDCENTER.KIN.PAGE", "PATIENT@MEDCENTER.KIN.PAGE", "AQAAAAIAAYagAAAAEKh7Qw8REglFqWkhoa/QJ3T/ux0V6F1sTILhn0JbaD8PzZvAh2wGKDa8uhLE1WdFpA==", "0958880540", false, "/images/Andriy.jpg", "adc12634-81d3-43a0-bbe1-339d21bf6229", false, "patient@medcenter.kin.page" },
                    { new Guid("cfdcbec0-c385-457d-b612-11f57d43fef1"), 0, "Somewhere st, Ukraine", 28, "fe3b4f7e-9588-4940-bbe9-70e0d57e0f6b", new DateOnly(1995, 6, 21), "patient@medcenter.babaka.page", true, "Бабаєв Віктор Вікторієвич", false, null, "PATIENT@MEDCENTER.BABAKA.PAGE", "PATIENT@MEDCENTER.BABAKA.PAGE", "AQAAAAIAAYagAAAAEHOjTCOsXLatJKNuU4vmmn57Rca98ejAE/KgahHao6D7hKKOPNfJ1wJ/hvMdpgU2Xw==", "0988885340", false, "/images/Viktor.jpg", "7379dca6-6035-4883-8e1d-a5a70747e119", false, "patient@medcenter.babaka.page" },
                    { new Guid("d9a5d6b6-b002-4e1a-923e-e1012a9f0642"), 0, "Somewhere st, Ukraine", 28, "4f34a199-f967-4ec7-af78-94ec304a1432", new DateOnly(1995, 6, 21), "doctor@medcenter.babaka.page", true, "Бабаєва Вікторія Вікторівна", false, null, "DOCTOR@MEDCENTER.BABAKA.PAGE", "DOCTOR@MEDCENTER.BABAKA.PAGE", "AQAAAAIAAYagAAAAECxodPzO+IaMR65h+B7vX1N4VXhwSxvt5GBQktB4aLxoNlNgUlMIRisbR0+3i68JSg==", "0999997890", false, "/images/cracked raiden shogun.jpg", "33bcaa8b-4b7e-42b8-9ddd-f6ef8d89ac1e", false, "doctor@medcenter.babaka.page" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "DateTime", "DoctorId", "PatientId", "Type" },
                values: new object[,]
                {
                    { new Guid("0e12631b-2108-4df2-9ea1-8ed0bc0a9e11"), new DateTime(2024, 6, 11, 1, 29, 21, 313, DateTimeKind.Local).AddTicks(8145), new Guid("5aecbc3c-641d-401e-b337-28f78b2f18dc"), new Guid("cfdcbec0-c385-457d-b612-11f57d43fef1"), "Виписка з лікарняного" },
                    { new Guid("7cdc9cfa-9900-4fca-acf8-81df347bc377"), new DateTime(2024, 6, 12, 20, 29, 21, 313, DateTimeKind.Local).AddTicks(8126), new Guid("d9a5d6b6-b002-4e1a-923e-e1012a9f0642"), new Guid("8ad50974-05c5-4f5e-aed4-065d7a04a1c3"), "Біль у горлі" },
                    { new Guid("c9423af2-c605-4264-a039-e848b55b96df"), new DateTime(2024, 6, 11, 20, 29, 21, 313, DateTimeKind.Local).AddTicks(8010), new Guid("d9a5d6b6-b002-4e1a-923e-e1012a9f0642"), new Guid("cfdcbec0-c385-457d-b612-11f57d43fef1"), "Проходження медогляду" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3960e876-9cd4-4e01-87bd-f16acd4d011c"), new Guid("5aecbc3c-641d-401e-b337-28f78b2f18dc") },
                    { new Guid("db7da560-149f-485d-97fd-ec65542e633b"), new Guid("8ad50974-05c5-4f5e-aed4-065d7a04a1c3") },
                    { new Guid("db7da560-149f-485d-97fd-ec65542e633b"), new Guid("cfdcbec0-c385-457d-b612-11f57d43fef1") },
                    { new Guid("3960e876-9cd4-4e01-87bd-f16acd4d011c"), new Guid("d9a5d6b6-b002-4e1a-923e-e1012a9f0642") },
                    { new Guid("74e2a366-df71-4512-bb15-e8a89be4efb0"), new Guid("d9a5d6b6-b002-4e1a-923e-e1012a9f0642") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedOn", "DoctorId", "MainText", "PatientId", "Title" },
                values: new object[,]
                {
                    { new Guid("8fa1421a-659c-4e76-a61e-80f9f4b15051"), new DateTime(2024, 6, 10, 20, 29, 21, 313, DateTimeKind.Local).AddTicks(8560), new Guid("5aecbc3c-641d-401e-b337-28f78b2f18dc"), "Назва коментаря вже все сказала за мене", new Guid("cfdcbec0-c385-457d-b612-11f57d43fef1"), "Найкраща сімейна лікарка" },
                    { new Guid("bc963092-dd8f-4900-9a00-1eaea905d4fe"), new DateTime(2024, 6, 10, 20, 29, 21, 313, DateTimeKind.Local).AddTicks(8538), new Guid("d9a5d6b6-b002-4e1a-923e-e1012a9f0642"), "Жахливе ставлення, відмовила приймати мене без черги, а мені було просто спитать", new Guid("8ad50974-05c5-4f5e-aed4-065d7a04a1c3"), "Немає слів" },
                    { new Guid("de2febd2-3e55-4f69-b1f9-3051ecf10860"), new DateTime(2024, 6, 10, 20, 29, 21, 313, DateTimeKind.Local).AddTicks(8483), new Guid("d9a5d6b6-b002-4e1a-923e-e1012a9f0642"), "Чудова лікарка, виписала направлення на безкоштовні аналізи, експіріенс десять з десяти", new Guid("cfdcbec0-c385-457d-b612-11f57d43fef1"), "Все супер" }
                });

            migrationBuilder.InsertData(
                table: "Diagnosis",
                columns: new[] { "Id", "Date", "DoctorId", "PatientId", "Perscription", "diagnosis" },
                values: new object[,]
                {
                    { new Guid("70a8a97e-f663-4165-8f6d-7122b3b75fc2"), new DateOnly(2024, 5, 8), new Guid("d9a5d6b6-b002-4e1a-923e-e1012a9f0642"), new Guid("cfdcbec0-c385-457d-b612-11f57d43fef1"), "Адаптол 1 таб. 2 р. на день, Гліцисед 1 таб. 3 р. на день, сон мінімум 10 годин на день", "Нервовий зрив" },
                    { new Guid("a0f0c7f1-7f0f-49d4-b1ae-5fe3ea2b491d"), new DateOnly(2023, 4, 29), new Guid("5aecbc3c-641d-401e-b337-28f78b2f18dc"), new Guid("cfdcbec0-c385-457d-b612-11f57d43fef1"), "Чай з малиною 4 р. на день, постільний режим", "Гострий бронхіт" },
                    { new Guid("e7954db2-1f66-4343-b7df-4ce2e3d3ba25"), new DateOnly(2023, 8, 18), new Guid("d9a5d6b6-b002-4e1a-923e-e1012a9f0642"), new Guid("8ad50974-05c5-4f5e-aed4-065d7a04a1c3"), "Чай з малиною 4 р. на день, постільний режим", "Ларингіт" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_DoctorId",
                table: "Diagnosis",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosis_AspNetUsers_DoctorId",
                table: "Diagnosis",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosis_AspNetUsers_DoctorId",
                table: "Diagnosis");

            migrationBuilder.DropIndex(
                name: "IX_Diagnosis_DoctorId",
                table: "Diagnosis");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0e12631b-2108-4df2-9ea1-8ed0bc0a9e11"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7cdc9cfa-9900-4fca-acf8-81df347bc377"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c9423af2-c605-4264-a039-e848b55b96df"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3960e876-9cd4-4e01-87bd-f16acd4d011c"), new Guid("5aecbc3c-641d-401e-b337-28f78b2f18dc") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("db7da560-149f-485d-97fd-ec65542e633b"), new Guid("8ad50974-05c5-4f5e-aed4-065d7a04a1c3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("db7da560-149f-485d-97fd-ec65542e633b"), new Guid("cfdcbec0-c385-457d-b612-11f57d43fef1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3960e876-9cd4-4e01-87bd-f16acd4d011c"), new Guid("d9a5d6b6-b002-4e1a-923e-e1012a9f0642") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("74e2a366-df71-4512-bb15-e8a89be4efb0"), new Guid("d9a5d6b6-b002-4e1a-923e-e1012a9f0642") });

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("8fa1421a-659c-4e76-a61e-80f9f4b15051"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("bc963092-dd8f-4900-9a00-1eaea905d4fe"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("de2febd2-3e55-4f69-b1f9-3051ecf10860"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("70a8a97e-f663-4165-8f6d-7122b3b75fc2"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("a0f0c7f1-7f0f-49d4-b1ae-5fe3ea2b491d"));

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: new Guid("e7954db2-1f66-4343-b7df-4ce2e3d3ba25"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3960e876-9cd4-4e01-87bd-f16acd4d011c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("74e2a366-df71-4512-bb15-e8a89be4efb0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("db7da560-149f-485d-97fd-ec65542e633b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5aecbc3c-641d-401e-b337-28f78b2f18dc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8ad50974-05c5-4f5e-aed4-065d7a04a1c3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cfdcbec0-c385-457d-b612-11f57d43fef1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9a5d6b6-b002-4e1a-923e-e1012a9f0642"));

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Diagnosis");

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
    }
}
