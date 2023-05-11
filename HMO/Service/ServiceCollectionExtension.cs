using Common.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Entities;
using Repository.Interfaces;
using Service.Interfaces;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using Service;

namespace Service
{
    public static class ServiceCollectionExtension
    {
        public static void AddService(this IServiceCollection service)
        {
            service.AddScoped<IService<MemberDTO>, Memberservice>();
            service.AddScoped<IService<VaccineDTO>, Vaccineservice>();
            service.AddAutoMapper(typeof(Mapper));
            service.AddRepository();
        }
    }
}
