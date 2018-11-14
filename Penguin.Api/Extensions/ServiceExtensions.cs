using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Penguin.Contracts;
using Penguin.LoggerService;

namespace Penguin.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            /*
             * We are using the basic settings for adding CORS policy because for this project allowing any origin,
             * method, and header is quite enough. But you can be more restrictive with those settings if you want.
             * Instead of the AllowAnyOrigin() method which allows requests from any source,
             * you could use the WithOrigins("http://www.something.com") which will allow requests just from the specified source.
             * Also, instead of AllowAnyMethod() that allows all HTTP methods,
             * you can use WithMethods("POST", "GET") that will allow only specified HTTP methods.
             * Furthermore, you can make the same changes for the AllowAnyHeader() method by using,
             * for example, the WithHeaders("accept", "content-type") method to allow only specified headers.
             */
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
    }
}
