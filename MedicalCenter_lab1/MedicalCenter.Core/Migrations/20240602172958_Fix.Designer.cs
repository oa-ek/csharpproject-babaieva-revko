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
    [Migration("20240602172958_Fix")]
    partial class Fix
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
                            Id = new Guid("32abdb5d-317f-4a4c-b916-867548678747"),
                            DateTime = new DateTime(2024, 6, 3, 20, 29, 56, 819, DateTimeKind.Local).AddTicks(7933),
                            DoctorId = new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d"),
                            PatientId = new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"),
                            Type = "Проходження медогляду"
                        },
                        new
                        {
                            Id = new Guid("5fafaaf5-1f33-4fb2-bcfc-3fe953a000e2"),
                            DateTime = new DateTime(2024, 6, 4, 20, 29, 56, 819, DateTimeKind.Local).AddTicks(8059),
                            DoctorId = new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d"),
                            PatientId = new Guid("f2450e15-75a9-40b7-8f35-28da9c8c5cd5"),
                            Type = "Біль у горлі"
                        },
                        new
                        {
                            Id = new Guid("789949da-2418-4932-9b7a-fc6b24b4df5b"),
                            DateTime = new DateTime(2024, 6, 3, 1, 29, 56, 819, DateTimeKind.Local).AddTicks(8073),
                            DoctorId = new Guid("710ed46e-7876-4463-957a-68c7228d37a4"),
                            PatientId = new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"),
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
                            Id = new Guid("8e635fd1-21b3-48a2-a111-4a3b57f4d7a5"),
                            CreatedOn = new DateTime(2024, 6, 2, 20, 29, 56, 819, DateTimeKind.Local).AddTicks(8404),
                            DoctorId = new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d"),
                            MainText = "Чудова лікарка, виписала направлення на безкоштовні аналізи, експіріенс десять з десяти",
                            PatientId = new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"),
                            Title = "Все супер"
                        },
                        new
                        {
                            Id = new Guid("440b80a2-8eeb-4892-8eef-5f4b8458a613"),
                            CreatedOn = new DateTime(2024, 6, 2, 20, 29, 56, 819, DateTimeKind.Local).AddTicks(8436),
                            DoctorId = new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d"),
                            MainText = "Жахливе ставлення, відмовила приймати мене без черги, а мені було просто спитать",
                            PatientId = new Guid("f2450e15-75a9-40b7-8f35-28da9c8c5cd5"),
                            Title = "Немає слів"
                        },
                        new
                        {
                            Id = new Guid("615d47d2-b83d-4e0b-aa25-a3d3673cf5de"),
                            CreatedOn = new DateTime(2024, 6, 2, 20, 29, 56, 819, DateTimeKind.Local).AddTicks(8452),
                            DoctorId = new Guid("710ed46e-7876-4463-957a-68c7228d37a4"),
                            MainText = "Назва коментаря вже все сказала за мене",
                            PatientId = new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"),
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
                            Id = new Guid("ff0b3c6f-fd99-4aa8-874c-7bc66e22f8dd"),
                            Date = new DateOnly(2023, 4, 29),
                            PatientId = new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"),
                            Perscription = "Чай з малиною 4 р. на день, постільний режим",
                            diagnosis = "Гострий бронхіт"
                        },
                        new
                        {
                            Id = new Guid("9425e5e6-29a2-4f0f-b7f9-2d312571b0c9"),
                            Date = new DateOnly(2023, 8, 18),
                            PatientId = new Guid("f2450e15-75a9-40b7-8f35-28da9c8c5cd5"),
                            Perscription = "Чай з малиною 4 р. на день, постільний режим",
                            diagnosis = "Ларингіт"
                        },
                        new
                        {
                            Id = new Guid("69b2e816-8750-411c-8799-583ce196124d"),
                            Date = new DateOnly(2024, 5, 8),
                            PatientId = new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"),
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
                            Id = new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d"),
                            AccessFailedCount = 0,
                            Address = "Somewhere st, Ukraine",
                            Age = 28,
                            ConcurrencyStamp = "695d4762-8729-4e4e-b88c-d31de898fc73",
                            DateOfBirth = new DateOnly(1995, 6, 21),
                            Email = "doctor@medcenter.babaka.page",
                            EmailConfirmed = true,
                            FullName = "Бабаєва Вікторія Вікторівна",
                            LockoutEnabled = false,
                            NormalizedEmail = "DOCTOR@MEDCENTER.BABAKA.PAGE",
                            NormalizedUserName = "DOCTOR@MEDCENTER.BABAKA.PAGE",
                            PasswordHash = "AQAAAAIAAYagAAAAEFTfGNnjcmMh0sLOvi4Ve2MDhWwfI29DgF7UYi3SM8ZLE8HR8AZ/SWptISaXcF3L6w==",
                            PhoneNumber = "0999997890",
                            PhoneNumberConfirmed = false,
                            Photo = "/images/cracked raiden shogun.jpg",
                            SecurityStamp = "8411183c-b6ae-4a7f-bb5e-c275379b1d6d",
                            TwoFactorEnabled = false,
                            UserName = "doctor@medcenter.babaka.page"
                        },
                        new
                        {
                            Id = new Guid("710ed46e-7876-4463-957a-68c7228d37a4"),
                            AccessFailedCount = 0,
                            Address = "SomewhereElse st, Ukraine",
                            Age = 25,
                            ConcurrencyStamp = "0e6c24fc-208e-4330-b272-1bcb8b2aa1f8",
                            DateOfBirth = new DateOnly(1998, 6, 21),
                            Email = "doctor@medcenter.kin.page",
                            EmailConfirmed = true,
                            FullName = "Коновал Анастасія Андріївна",
                            LockoutEnabled = false,
                            NormalizedEmail = "DOCTOR@MEDCENTER.KIN.PAGE",
                            NormalizedUserName = "DOCTOR@MEDCENTER.KIN.PAGE",
                            PasswordHash = "AQAAAAIAAYagAAAAEIIPtpwrgpJlJV+0B89h/hNLR9WE+nB966vb4y8zmbqiejVr9BcbbEZ8e64Gu8wobg==",
                            PhoneNumber = "0966665432",
                            PhoneNumberConfirmed = false,
                            Photo = "/images/cracked yae miko.jpg",
                            SecurityStamp = "74320bdb-2895-4024-ad0c-f4878abac44e",
                            TwoFactorEnabled = false,
                            UserName = "doctor@medcenter.kin.page"
                        },
                        new
                        {
                            Id = new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"),
                            AccessFailedCount = 0,
                            Address = "Somewhere st, Ukraine",
                            Age = 28,
                            ConcurrencyStamp = "5da28c58-8cb8-4ea9-b35e-93d48e9abb0b",
                            DateOfBirth = new DateOnly(1995, 6, 21),
                            Email = "patient@medcenter.babaka.page",
                            EmailConfirmed = true,
                            FullName = "Бабаєв Віктор Вікторієвич",
                            LockoutEnabled = false,
                            NormalizedEmail = "PATIENT@MEDCENTER.BABAKA.PAGE",
                            NormalizedUserName = "PATIENT@MEDCENTER.BABAKA.PAGE",
                            PasswordHash = "AQAAAAIAAYagAAAAEGED3PNg9A66zNhkCqWfecS2bqd9K+RKt75IDsDIe5BK/7HLoXDGDYv+Y/GrOE8H5w==",
                            PhoneNumber = "0988885340",
                            PhoneNumberConfirmed = false,
                            Photo = "/images/Viktor.jpg",
                            SecurityStamp = "45dc7be0-f44c-47f5-ad71-f6ca5775806c",
                            TwoFactorEnabled = false,
                            UserName = "patient@medcenter.babaka.page"
                        },
                        new
                        {
                            Id = new Guid("f2450e15-75a9-40b7-8f35-28da9c8c5cd5"),
                            AccessFailedCount = 0,
                            Address = "SomewhereElse st, Ukraine",
                            Age = 25,
                            ConcurrencyStamp = "beb91beb-42bd-4687-aae4-36439ca10885",
                            DateOfBirth = new DateOnly(1998, 6, 21),
                            Email = "patient@medcenter.kin.page",
                            EmailConfirmed = true,
                            FullName = "Коновал Андрій Анастасійович",
                            LockoutEnabled = false,
                            NormalizedEmail = "PATIENT@MEDCENTER.KIN.PAGE",
                            NormalizedUserName = "PATIENT@MEDCENTER.KIN.PAGE",
                            PasswordHash = "AQAAAAIAAYagAAAAENZ47VfggFs+CX3TsLmFdUQ0xzeQQPEByWvPFoksIR1Wn2zb/3m78gIn81Pg+4QgZQ==",
                            PhoneNumber = "0958880540",
                            PhoneNumberConfirmed = false,
                            Photo = "/images/Andriy.jpg",
                            SecurityStamp = "09f33b72-61f0-4f54-940d-6731ad793771",
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
                            Id = new Guid("1e2a6c95-afda-40c2-950d-d72ccd996ccf"),
                            ConcurrencyStamp = "1e2a6c95-afda-40c2-950d-d72ccd996ccf",
                            Name = "Doctor",
                            NormalizedName = "DOCTOR"
                        },
                        new
                        {
                            Id = new Guid("6466463a-908e-429c-851d-e1a6899d21f3"),
                            ConcurrencyStamp = "6466463a-908e-429c-851d-e1a6899d21f3",
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
                            UserId = new Guid("70a00254-c0f1-4cdc-a057-f09b65ef780d"),
                            RoleId = new Guid("1e2a6c95-afda-40c2-950d-d72ccd996ccf")
                        },
                        new
                        {
                            UserId = new Guid("710ed46e-7876-4463-957a-68c7228d37a4"),
                            RoleId = new Guid("1e2a6c95-afda-40c2-950d-d72ccd996ccf")
                        },
                        new
                        {
                            UserId = new Guid("b682cd6f-8297-43df-9bf4-ef6402c51e9f"),
                            RoleId = new Guid("6466463a-908e-429c-851d-e1a6899d21f3")
                        },
                        new
                        {
                            UserId = new Guid("f2450e15-75a9-40b7-8f35-28da9c8c5cd5"),
                            RoleId = new Guid("6466463a-908e-429c-851d-e1a6899d21f3")
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
