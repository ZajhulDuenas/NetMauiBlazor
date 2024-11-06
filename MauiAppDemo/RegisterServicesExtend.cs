﻿using Front.Infrastructure.ClientApi;
using Microsoft.Extensions.Configuration;

namespace MauiAppDemo
{
    public static class RegisterServicesExtend
    {
        public static void RegisterServices(this IServiceCollection services,
          IConfiguration configuration)
        {

            if (services == null || configuration == null)
                return;

            services.AddTransient<ITokenServiceClient, TokenServiceClient>();
            services.AddTransient<IEmployeersClient, EmployeersClient>();
            // services.Configure<TokenServiceSettings>(configuration.GetSection("TokenServiceSettings"));


        }
    }
}