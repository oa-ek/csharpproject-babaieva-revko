using MedicalCenter.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicalCenter.Core.Context
{
    public class ProjectContext : IdentityDbContext<User>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }


        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(u => u.DoctorAppointments)
                .HasForeignKey(a => a.DoctorId)
                .IsRequired(false);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(u => u.PatientAppointments)
                .HasForeignKey(a => a.PatientId)
                .IsRequired(false);

            modelBuilder.Entity<Comment>()
                .HasOne(a => a.Doctor)
                .WithMany(u => u.DoctorComments)
                .HasForeignKey(a => a.DoctorId)
                .IsRequired(false);

            modelBuilder.Entity<Comment>()
                .HasOne(a => a.Patient)
                .WithMany(u => u.PatientComments)
                .HasForeignKey(a => a.PatientId)
                .IsRequired(false);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Appointment> Appointments  => Set<Appointment>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<Diagnosis> Diagnosis => Set<Diagnosis>();

    }
}
