﻿using AIS.DAL.Interfaces.Repositories;
using AIS.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AIS.DAL.DI
{
    public static class DataAccessRegister
    {
        public static void AddDataAccess(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddDbContext<DatabaseContext>(op =>
                {
                    op.UseSqlServer(config.GetConnectionString("DefaultConnection"));
                }
            );
        }
    }
}