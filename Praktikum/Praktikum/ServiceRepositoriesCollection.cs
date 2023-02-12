using Microsoft.Extensions.DependencyInjection;
using Praktikum.Repository.entities;
using Praktikum.Repository.Interface;
using Praktikum.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum.Repository
{
    public static class ServiceRepositoriesCollection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICrud<User>, UserRepository>();
            services.AddScoped<ICrud<Child>, ChildRepository>();
            return services;
        }
    }
}
