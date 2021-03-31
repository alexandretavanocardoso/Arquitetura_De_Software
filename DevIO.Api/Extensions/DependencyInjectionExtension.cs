using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void ResolveDependencies(this IServiceCollection services)
        {
            AddDependenciesRepositories(services);
            AddDependenciesServices(services);
        }

        static void AddDependenciesRepositories(IServiceCollection services)
        {
            // services.AddScoped<InterfaceRepositorio, Repositorio>();
        }

        static void AddDependenciesServices(IServiceCollection services)
        {
            // services.AddScoped<InterfaceServico, Servico>();
        }
    }
}