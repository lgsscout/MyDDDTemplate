using $ext_safeprojectname$.Application;
using $ext_safeprojectname$.Application.Interfaces;
using $ext_safeprojectname$.Domain.Interfaces.Repository;
using $ext_safeprojectname$.Domain.Interfaces.Repository.Common;
using $ext_safeprojectname$.Domain.Interfaces.Service;
using $ext_safeprojectname$.Domain.Services;
using $ext_safeprojectname$.Infra.Data.Context;
using $ext_safeprojectname$.Infra.Data.Context.Interfaces;
using $ext_safeprojectname$.Infra.Data.Repository.EntityFramework;
using $ext_safeprojectname$.Infra.Data.Repository.EntityFramework.Common;
using Microsoft.Extensions.DependencyInjection;

namespace $safeprojectname$
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Infra
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Domain Services
            services.AddScoped<IExampleService, ExampleService>();

            // App Services
            services.AddScoped<IExampleAppService, ExampleAppService>();

            // Repository
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IExampleRepository, ExampleRepository>();
        }
    }
}
