using ECommerceApi.Application.Abstactions;
using ECommerceApi.Persistence.Concretes;
using ECommerceApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceApiDbContext>(options=>options.UseSqlServer("Server=DESKTOP-NTCQAJV;Database=ECommerceDb;Trusted_Connection=True;TrustServerCertificate=True;"));
        }
    }
}
