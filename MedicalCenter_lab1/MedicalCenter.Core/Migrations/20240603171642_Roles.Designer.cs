﻿// <auto-generated />
using System;
using MedicalCenter.Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedicalCenter.Core.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20240603171642_Roles")]
    partial class Roles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MedicalCenter.Core.Entities.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("29d85ba2-8b8f-47c1-873f-4577ccea0fd1"),
                            DateTime = new DateTime(2024, 6, 4, 20, 16, 41, 274, DateTimeKind.Local).AddTicks(7803),
                            DoctorId = new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"),
                            PatientId = new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"),
                            Type = "Проходження медогляду"
                        },
                        new
                        {
                            Id = new Guid("ab607105-d684-4782-9afb-ad3584aab03a"),
                            DateTime = new DateTime(2024, 6, 5, 20, 16, 41, 274, DateTimeKind.Local).AddTicks(7938),
                            DoctorId = new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"),
                            PatientId = new Guid("90aa2d7f-5593-4171-867e-d89c236f3ce5"),
                            Type = "Біль у горлі"
                        },
                        new
                        {
                            Id = new Guid("c945eec5-aeb8-48ef-b8a9-a877fe4dc27d"),
                            DateTime = new DateTime(2024, 6, 4, 1, 16, 41, 274, DateTimeKind.Local).AddTicks(7947),
                            DoctorId = new Guid("27e4ca5a-1242-4f47-86a1-6437052b6700"),
                            PatientId = new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"),
                            Type = "Виписка з лікарняного"
                        });
                });

            modelBuilder.Entity("MedicalCenter.Core.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MainText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("111f2a8f-e036-4884-9d36-9457bc534526"),
                            CreatedOn = new DateTime(2024, 6, 3, 20, 16, 41, 274, DateTimeKind.Local).AddTicks(8221),
                            DoctorId = new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"),
                            MainText = "Чудова лікарка, виписала направлення на безкоштовні аналізи, експіріенс десять з десяти",
                            PatientId = new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"),
                            Title = "Все супер"
                        },
                        new
                        {
                            Id = new Guid("a8c13a79-ea4b-46ff-80ef-6e61da9e5eb7"),
                            CreatedOn = new DateTime(2024, 6, 3, 20, 16, 41, 274, DateTimeKind.Local).AddTicks(8252),
                            DoctorId = new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"),
                            MainText = "Жахливе ставлення, відмовила приймати мене без черги, а мені було просто спитать",
                            PatientId = new Guid("90aa2d7f-5593-4171-867e-d89c236f3ce5"),
                            Title = "Немає слів"
                        },
                        new
                        {
                            Id = new Guid("21c23937-d567-45ac-b302-7c7f5da93cb7"),
                            CreatedOn = new DateTime(2024, 6, 3, 20, 16, 41, 274, DateTimeKind.Local).AddTicks(8266),
                            DoctorId = new Guid("27e4ca5a-1242-4f47-86a1-6437052b6700"),
                            MainText = "Назва коментаря вже все сказала за мене",
                            PatientId = new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"),
                            Title = "Найкраща сімейна лікарка"
                        });
                });

            modelBuilder.Entity("MedicalCenter.Core.Entities.Diagnosis", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly?>("Date")
                        .HasColumnType("date");

                    b.Property<Guid?>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Perscription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Diagnosis");

                    b.HasData(
                        new
                        {
                            Id = new Guid("23c3bac6-2259-4b11-aa6e-2d7b95517f30"),
                            Date = new DateOnly(2023, 4, 29),
                            PatientId = new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"),
                            Perscription = "Чай з малиною 4 р. на день, постільний режим",
                            diagnosis = "Гострий бронхіт"
                        },
                        new
                        {
                            Id = new Guid("50fd0fad-24f4-454c-97fd-dcec971ddacf"),
                            Date = new DateOnly(2023, 8, 18),
                            PatientId = new Guid("90aa2d7f-5593-4171-867e-d89c236f3ce5"),
                            Perscription = "Чай з малиною 4 р. на день, постільний режим",
                            diagnosis = "Ларингіт"
                        },
                        new
                        {
                            Id = new Guid("d4db9cae-fb72-4063-bdaf-5f2d12d91e77"),
                            Date = new DateOnly(2024, 5, 8),
                            PatientId = new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"),
                            Perscription = "Адаптол 1 таб. 2 р. на день, Гліцисед 1 таб. 3 р. на день, сон мінімум 10 годин на день",
                            diagnosis = "Нервовий зрив"
                        });
                });

            modelBuilder.Entity("MedicalCenter.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"),
                            AccessFailedCount = 0,
                            Address = "Somewhere st, Ukraine",
                            Age = 28,
                            ConcurrencyStamp = "c00e1fd0-bc96-48c1-960b-040db8f71a57",
                            DateOfBirth = new DateOnly(1995, 6, 21),
                            Email = "doctor@medcenter.babaka.page",
                            EmailConfirmed = true,
                            FullName = "Бабаєва Вікторія Вікторівна",
                            LockoutEnabled = false,
                            NormalizedEmail = "DOCTOR@MEDCENTER.BABAKA.PAGE",
                            NormalizedUserName = "DOCTOR@MEDCENTER.BABAKA.PAGE",
                            PasswordHash = "AQAAAAIAAYagAAAAEHr2GevPVyPlPJ6bBLVZ2G4jskRMhFN5aO0WXkWEyZj17FbtiJKqPcR7B85cMSpZVg==",
                            PhoneNumber = "0999997890",
                            PhoneNumberConfirmed = false,
                            Photo = "/images/cracked raiden shogun.jpg",
                            SecurityStamp = "182145e6-6bd7-48e6-9264-6823b752adf8",
                            TwoFactorEnabled = false,
                            UserName = "doctor@medcenter.babaka.page"
                        },
                        new
                        {
                            Id = new Guid("27e4ca5a-1242-4f47-86a1-6437052b6700"),
                            AccessFailedCount = 0,
                            Address = "SomewhereElse st, Ukraine",
                            Age = 25,
                            ConcurrencyStamp = "56ce4f52-bb31-4b93-b0f9-214cc78637ac",
                            DateOfBirth = new DateOnly(1998, 6, 21),
                            Email = "doctor@medcenter.kin.page",
                            EmailConfirmed = true,
                            FullName = "Коновал Анастасія Андріївна",
                            LockoutEnabled = false,
                            NormalizedEmail = "DOCTOR@MEDCENTER.KIN.PAGE",
                            NormalizedUserName = "DOCTOR@MEDCENTER.KIN.PAGE",
                            PasswordHash = "AQAAAAIAAYagAAAAEHYDupy59tuXIgEZhird1IkUb2KZ5qMDDG+ALE/suEENcugJGnUoMnbyHV8KeIos8w==",
                            PhoneNumber = "0966665432",
                            PhoneNumberConfirmed = false,
                            Photo = "/images/cracked yae miko.jpg",
                            SecurityStamp = "84b39260-b1c9-4438-bec0-000bdfded724",
                            TwoFactorEnabled = false,
                            UserName = "doctor@medcenter.kin.page"
                        },
                        new
                        {
                            Id = new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"),
                            AccessFailedCount = 0,
                            Address = "Somewhere st, Ukraine",
                            Age = 28,
                            ConcurrencyStamp = "c0ad8b6d-9634-4216-bd20-cba1a19d4975",
                            DateOfBirth = new DateOnly(1995, 6, 21),
                            Email = "patient@medcenter.babaka.page",
                            EmailConfirmed = true,
                            FullName = "Бабаєв Віктор Вікторієвич",
                            LockoutEnabled = false,
                            NormalizedEmail = "PATIENT@MEDCENTER.BABAKA.PAGE",
                            NormalizedUserName = "PATIENT@MEDCENTER.BABAKA.PAGE",
                            PasswordHash = "AQAAAAIAAYagAAAAEBupe0vtA6a/DaPOsKrH6X0vwUOxaHgrHrDyGnT+ZURLuuQiaOOSvS5JiDzvmp80oQ==",
                            PhoneNumber = "0988885340",
                            PhoneNumberConfirmed = false,
                            Photo = "/images/Viktor.jpg",
                            SecurityStamp = "888c65f5-8493-45c2-8797-fa22ad4f72fe",
                            TwoFactorEnabled = false,
                            UserName = "patient@medcenter.babaka.page"
                        },
                        new
                        {
                            Id = new Guid("90aa2d7f-5593-4171-867e-d89c236f3ce5"),
                            AccessFailedCount = 0,
                            Address = "SomewhereElse st, Ukraine",
                            Age = 25,
                            ConcurrencyStamp = "33df26a1-a114-4444-9c00-43467ec8fe6f",
                            DateOfBirth = new DateOnly(1998, 6, 21),
                            Email = "patient@medcenter.kin.page",
                            EmailConfirmed = true,
                            FullName = "Коновал Андрій Анастасійович",
                            LockoutEnabled = false,
                            NormalizedEmail = "PATIENT@MEDCENTER.KIN.PAGE",
                            NormalizedUserName = "PATIENT@MEDCENTER.KIN.PAGE",
                            PasswordHash = "AQAAAAIAAYagAAAAEFLjlg7OZKv5ceXFfWoK6EaHMkw6JN1plFhOovEVs+tB9rQo141enQyTiArK04M4/Q==",
                            PhoneNumber = "0958880540",
                            PhoneNumberConfirmed = false,
                            Photo = "/images/Andriy.jpg",
                            SecurityStamp = "fa00471a-a3fb-40d2-837d-745d9dc7f7f4",
                            TwoFactorEnabled = false,
                            UserName = "patient@medcenter.kin.page"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("28ffd9e3-dfaf-4894-952f-239f0aec10ed"),
                            ConcurrencyStamp = "28ffd9e3-dfaf-4894-952f-239f0aec10ed",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("be18057e-0c85-4a26-a622-38c77cd1617e"),
                            ConcurrencyStamp = "be18057e-0c85-4a26-a622-38c77cd1617e",
                            Name = "Doctor",
                            NormalizedName = "DOCTOR"
                        },
                        new
                        {
                            Id = new Guid("4968d747-e70f-42c5-a683-afc83da968ab"),
                            ConcurrencyStamp = "4968d747-e70f-42c5-a683-afc83da968ab",
                            Name = "Patient",
                            NormalizedName = "PATIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"),
                            RoleId = new Guid("be18057e-0c85-4a26-a622-38c77cd1617e")
                        },
                        new
                        {
                            UserId = new Guid("f762165f-7813-43b5-a47f-3ac8703853cb"),
                            RoleId = new Guid("28ffd9e3-dfaf-4894-952f-239f0aec10ed")
                        },
                        new
                        {
                            UserId = new Guid("27e4ca5a-1242-4f47-86a1-6437052b6700"),
                            RoleId = new Guid("be18057e-0c85-4a26-a622-38c77cd1617e")
                        },
                        new
                        {
                            UserId = new Guid("9f762c3c-b786-40d4-a0ba-a3cb099f7cc9"),
                            RoleId = new Guid("4968d747-e70f-42c5-a683-afc83da968ab")
                        },
                        new
                        {
                            UserId = new Guid("90aa2d7f-5593-4171-867e-d89c236f3ce5"),
                            RoleId = new Guid("4968d747-e70f-42c5-a683-afc83da968ab")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MedicalCenter.Core.Entities.Appointment", b =>
                {
                    b.HasOne("MedicalCenter.Core.Entities.User", "Doctor")
                        .WithMany("DoctorAppointments")
                        .HasForeignKey("DoctorId");

                    b.HasOne("MedicalCenter.Core.Entities.User", "Patient")
                        .WithMany("PatientAppointments")
                        .HasForeignKey("PatientId");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("MedicalCenter.Core.Entities.Comment", b =>
                {
                    b.HasOne("MedicalCenter.Core.Entities.User", "Doctor")
                        .WithMany("DoctorComments")
                        .HasForeignKey("DoctorId");

                    b.HasOne("MedicalCenter.Core.Entities.User", "Patient")
                        .WithMany("PatientComments")
                        .HasForeignKey("PatientId");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("MedicalCenter.Core.Entities.Diagnosis", b =>
                {
                    b.HasOne("MedicalCenter.Core.Entities.User", "Patient")
                        .WithMany("MedRecord")
                        .HasForeignKey("PatientId");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("MedicalCenter.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("MedicalCenter.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalCenter.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("MedicalCenter.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MedicalCenter.Core.Entities.User", b =>
                {
                    b.Navigation("DoctorAppointments");

                    b.Navigation("DoctorComments");

                    b.Navigation("MedRecord");

                    b.Navigation("PatientAppointments");

                    b.Navigation("PatientComments");
                });
#pragma warning restore 612, 618
        }
    }
}