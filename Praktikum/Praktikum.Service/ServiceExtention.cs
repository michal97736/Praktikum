using Microsoft.Extensions.DependencyInjection;
using Praktikum.Common.DTOs;
using Praktikum.DBContext;
using Praktikum.Repository;
using Praktikum.Service.Interface;
using Praktikum.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum.Service
{
	public static class ServiceExtention
	{
		public static IServiceCollection AddService(this IServiceCollection services)
		{
			services.AddRepositories();
			services.AddScoped<ICrudService<UserDTO>, UserService>();
			services.AddScoped<ICrudService<ChildDTO>, ChildService>();
			services.AddSingleton<IContext, MyDBContext>();
			services.AddAutoMapper(typeof(Mapping));
			
			return services;
		}
	}
}
