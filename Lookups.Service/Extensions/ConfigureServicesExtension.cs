using Common.StandardInfrastructure.Repository;
using Lookups.Data;
using Lookups.Data.SeedData;
using Lookups.DataAccess;
using Lookups.Service.AutoMapper;
using Lookups.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using System.Reflection;

namespace Lookups.Service.Extensions
{
    public static class ConfigureServicesExtension
    {
        public static IServiceCollection ServicesRegisterConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.DatabaseConfig(configuration);
            services.AddAutoMapper(typeof(LookupsProfile));
            services.ServicesConfig();
            return services;
        }
        private static void DatabaseConfig(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("TAMS");

            services.AddDbContext<LookupsContext>
                (options => options.UseSqlServer(connectionString));
            services.AddScoped<DbContext, LookupsContext>();
        }
        private static void ServicesConfig(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IDataInitialize, DataInitialize>();
            var assemblyToScan = Assembly.GetAssembly(typeof(CountryService));
            services.RegisterAssemblyPublicNonGenericClasses(assemblyToScan).Where(c => c.Name.EndsWith("Service"))
              .AsPublicImplementedInterfaces();
        }
    }
}
