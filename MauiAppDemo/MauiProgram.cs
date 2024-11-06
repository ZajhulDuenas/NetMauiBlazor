﻿using MauiAppDemo.Pages;
using Microsoft.Extensions.Logging;

namespace MauiAppDemo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

          
            // Add services to the container.
            builder.Services.RegisterServices(builder.Configuration);

            //  builder.Services.AddSingleton(App.Settings);


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}