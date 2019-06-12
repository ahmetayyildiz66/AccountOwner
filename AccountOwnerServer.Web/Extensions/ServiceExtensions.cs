using AccountOwnerServer.Business;
using AccountOwnerServer.Business.Contracts;
using AccountOwnerServer.Common.Contracts;
using AccountOwnerServer.Common.Mappings;
using AccountOwnerServer.Data;
using AccountOwnerServer.Data.Contracts;
using AccountOwnerServer.Logging;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountOwnerServer.Web.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(config.GetConnectionString("DbConnection")));
        }

        public static void ConfigureEngineWithInterface(this IServiceCollection services)
        {
            services.AddScoped<IOwnerRepository, OwnerRepository>();
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        public static void ConfigureEngines(this IServiceCollection services)
        {
            services.AddScoped<IOwnerEngine, OwnerEngine>();
            services.AddScoped<IAccountEngine, AccountEngine>();
        }

        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper();
        }

        
    }
}
