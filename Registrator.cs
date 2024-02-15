using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SimpleLibraryTestTwo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryTestTwo
{
    public static class Registrator
    {
        public static IServiceCollection AddYanterMapper(this IServiceCollection services)
        {
            services.TryAddTransient(typeof(IYanterMapper), typeof(AutoMapBuilder));
            return services;
        }
    }
}
