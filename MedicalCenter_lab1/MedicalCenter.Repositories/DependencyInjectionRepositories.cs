using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Appointments;
using MedicalCenter.Repositories.Comments;
using MedicalCenter.Repositories.Common;
using MedicalCenter.Repositories.Diagnoses;
using MedicalCenter.Repositories.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Repositories
{
    public static class DependencyInjectionRepositories
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
            services.AddScoped<IAppointmentRepository,AppointmentRepository>();
            services.AddScoped<ICommentRepository,CommentRepository>();
            services.AddScoped<IDiagnosisRepository, DiagnosisRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

        }
    }
}
