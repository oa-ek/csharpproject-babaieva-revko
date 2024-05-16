using MedicalCenter.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Core.Context
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            var (dID, pID) = _seedRoles(builder);
            var (dId1,dId2) = _seedDoctors(builder, dID);
            var (pId1,pId2) = _seedPatients(builder, pID);
            _seedAppointment(builder, dId1,dId2, pId1,pId2);
            _seedComment(builder, dId1, dId2, pId1, pId2);
            _seedDiagnosis(builder, pId1,pId2);
        }
        private static (Guid, Guid) _seedRoles(ModelBuilder builder)
        {
            var DOCTOR_ROLE_ID = Guid.NewGuid();
            var PATIENT_ROLE_ID = Guid.NewGuid();

            builder.Entity<IdentityRole<Guid>>()
                .HasData(
                new IdentityRole<Guid>
                {
                    Id = DOCTOR_ROLE_ID,
                    Name = "Doctor",
                    NormalizedName = "DOCTOR",
                    ConcurrencyStamp = DOCTOR_ROLE_ID.ToString()
                },
                new IdentityRole<Guid>
                {
                    Id = PATIENT_ROLE_ID,
                    Name = "Patient",
                    NormalizedName = "PATIENT",
                    ConcurrencyStamp = PATIENT_ROLE_ID.ToString(),
                }
                );
            return (DOCTOR_ROLE_ID, PATIENT_ROLE_ID);
        }
        static (Guid, Guid) _seedDoctors(ModelBuilder builder, Guid DOCTOR_ROLE_ID)
        {
            var doctorId = Guid.NewGuid();
            var doctorId2 = Guid.NewGuid();

            var doctor = new User
            {

                Id = doctorId,
                UserName = "doctor@medcenter.babaka.page",
                EmailConfirmed = true,
                NormalizedUserName = "doctor@medcenter.babaka.page".ToUpper(),
                Email = "doctor@medcenter.babaka.page",
                NormalizedEmail = "doctor@medcenter.babaka.page".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString(),
                FullName = "Бабаєва Вікторія Вікторівна",
                Age = 28,
                DateOfBirth = new DateOnly(1995, 06, 21),
                Address = "Somewhere st, Ukraine",
                Photo = "/images/cracked raiden shogun.jpg"
            };
            var doctor2 = new User
            {
                Id = doctorId2,
                UserName = "doctor@medcenter.kin.page",
                EmailConfirmed = true,
                NormalizedUserName = "doctor@medcenter.kin.page".ToUpper(),
                Email = "doctor@medcenter.kin.page",
                NormalizedEmail = "doctor@medcenter.kin.page".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString(),
                FullName = "Коновал Анастасія Андріївна",
                Age = 25,
                DateOfBirth = new DateOnly(1998, 06, 21),
                Address = "SomewhereElse st, Ukraine",
                Photo = "/images/cracked yae miko.jpg"


            };

            PasswordHasher < User > passwordHasher = new PasswordHasher<User>();
            doctor.PasswordHash = passwordHasher.HashPassword(doctor, "MedCenter08");
            doctor.PasswordHash = passwordHasher.HashPassword(doctor2, "MedCenter21");

            builder.Entity<User>()
         .HasData(doctor);

            builder.Entity<IdentityUserRole<Guid>>()
                  .HasData(
                      new IdentityUserRole<Guid>
                      {
                          RoleId = DOCTOR_ROLE_ID,
                          UserId = doctorId
                      }

                  );
            builder.Entity<User>()
.HasData(doctor2);

            builder.Entity<IdentityUserRole<Guid>>()
                  .HasData(
                      new IdentityUserRole<Guid>
                      {
                          RoleId = DOCTOR_ROLE_ID,
                          UserId = doctorId2
                      }

                  );

            return (doctorId,doctorId2);
        }

    


            static (Guid, Guid) _seedPatients(ModelBuilder builder, Guid PATIENT_ROLE_ID)
            {
                var patientId = Guid.NewGuid();
                var patientId2 = Guid.NewGuid();
                var patient = new User 
                {
                    Id = patientId,
                    UserName = "patient@medcenter.babaka.page",
                    EmailConfirmed = true,
                    NormalizedUserName = "patient@medcenter.babaka.page".ToUpper(),
                    Email = "patient@medcenter.babaka.page",
                    NormalizedEmail = "patient@medcenter.babaka.page".ToUpper(),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FullName = "Бабаєв Віктор Вікторієвич",
                    Age = 28,
                    DateOfBirth = new DateOnly(1995, 06, 21),
                    Address = "Somewhere st, Ukraine",
                    Photo = "/images/Viktor.jpg"
                };
            var patient2 = new User
            {
                Id = patientId2,
                UserName = "patient@medcenter.kin.page",
                EmailConfirmed = true,
                NormalizedUserName = "patient@medcenter.kin.page".ToUpper(),
                Email = "patient@medcenter.kin.page",
                NormalizedEmail = "patient@medcenter.kin.page".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString(),
                FullName = "Коновал Андрій Анастасійович",
                Age = 25,
                DateOfBirth = new DateOnly(1998, 06, 21),
                Address = "SomewhereElse st, Ukraine",
                Photo = "/images/Andriy.jpg"
            };


            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
                 patient.PasswordHash = passwordHasher.HashPassword(patient, "MedCenter08");
                 patient2.PasswordHash = passwordHasher.HashPassword(patient2, "MedCenter21");

            builder.Entity<User>()
.HasData(patient);

            builder.Entity<IdentityUserRole<Guid>>()
                  .HasData(
                      new IdentityUserRole<Guid>
                      {
                          RoleId = PATIENT_ROLE_ID,
                          UserId = patientId
                      }

                  );
            builder.Entity<User>()
.HasData(patient2);

            builder.Entity<IdentityUserRole<Guid>>()
                  .HasData(
                      new IdentityUserRole<Guid>
                      {
                          RoleId = PATIENT_ROLE_ID,
                          UserId = patientId2
                      }

                  );


            return (patientId,patientId2);
            }
            static void _seedAppointment(ModelBuilder builder, Guid doctorId, Guid doctorId2, Guid patientId, Guid patientId2)
            {
                builder.Entity<Appointment>().HasData(new List<Appointment> { 
                    new Appointment 
                    {Id = Guid.NewGuid(),
                        DateTime = DateTime.Now.AddDays(1),
                        Type = "Проходження медогляду",
                        DoctorId = doctorId,
                        PatientId = patientId
                    },
                    new Appointment
                    {Id = Guid.NewGuid(),
                        DateTime = DateTime.Now.AddDays(2),
                        Type = "Біль у горлі",
                        DoctorId = doctorId,
                        PatientId = patientId2
                    },
                    new Appointment
                    {Id = Guid.NewGuid(),
                        DateTime = DateTime.Now.AddHours(5),
                        Type = "Виписка з лікарняного",
                        DoctorId = doctorId2,
                        PatientId = patientId
                    }
                });
            }
            static void _seedComment(ModelBuilder builder, Guid doctorId, Guid doctorId2, Guid patientId, Guid patientId2)
            {
    builder.Entity<Comment>().HasData(new List<Comment>
                {
                    new Comment
                    {
                    Id = Guid.NewGuid(),
                    Title = "Все супер",
                    MainText = "Чудова лікарка, виписала направлення на безкоштовні аналізи, експіріенс десять з десяти",
                    CreatedOn = DateTime.Now,
                    DoctorId = doctorId,
                    PatientId = patientId
                    },
                    new Comment
                    {Id = Guid.NewGuid(),
                    Title = "Немає слів",
                    MainText = "Жахливе ставлення, відмовила приймати мене без черги, а мені було просто спитать",
                    CreatedOn = DateTime.Now,
                    DoctorId = doctorId,
                    PatientId = patientId2
                    },
                    new Comment
                    {Id = Guid.NewGuid(),
                    Title = "Найкраща сімейна лікарка",
                    MainText = "Назва коментаря вже все сказала за мене",
                    CreatedOn = DateTime.Now,
                    DoctorId = doctorId2,
                    PatientId = patientId
                    }
                }) ;
                
            }
            static void _seedDiagnosis(ModelBuilder builder, Guid patientId, Guid patientId2)
            {
                builder.Entity<Diagnosis>().HasData(new List<Diagnosis>
                {
                new Diagnosis
                {Id = Guid.NewGuid(),
                    Date = new DateOnly(2023,04,29),
                    diagnosis = "Гострий бронхіт",
                    Perscription = "Чай з малиною 4 р. на день, постільний режим",
                    PatientId = patientId
                },
               new Diagnosis
                {Id = Guid.NewGuid(),
                    Date = new DateOnly(2023,08,18),
                    diagnosis = "Ларингіт",
                    Perscription = "Чай з малиною 4 р. на день, постільний режим",
                    PatientId = patientId2
                },
               new Diagnosis
                {Id = Guid.NewGuid(),
                    Date = new DateOnly(2024,05,08),
                    diagnosis = "Нервовий зрив",
                    Perscription = "Адаптол 1 таб. 2 р. на день, Гліцисед 1 таб. 3 р. на день, сон мінімум 10 годин на день",
                    PatientId = patientId
                }
                });

            }


        }
    }

