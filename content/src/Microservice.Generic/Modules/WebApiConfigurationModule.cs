using Microservice.Generic.v2.Validation;
using Microservice.Generic.v2.Validation.Impl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Generic.Modules
{
    public static class WebApiConfigurationModule
    {
        public static void AddCustomizedWebApi(this IServiceCollection services)
        {
            services.AddScoped<IValueValidator, ValueValidator>();
        }
    }
}
