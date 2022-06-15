using Microsoft.Extensions.DependencyInjection;
using Shapes.Services.Interfaces;
using Shapes.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Services
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAreaService, AreaService>();
            return services;
        }
    }
}
