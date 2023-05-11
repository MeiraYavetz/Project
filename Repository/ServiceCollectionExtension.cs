using Microsoft.Extensions.DependencyInjection;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class ServiceCollectionExtension
    {
        public static void AddRepository(this IServiceCollection service)
        {
            service.AddScoped<IRepository<Member>, MemberRepository>();
            service.AddScoped<IRepository<Vaccine>, VaccineRepository>();
        }
    }
}
