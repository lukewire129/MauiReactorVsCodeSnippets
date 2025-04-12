﻿using MauiReactor;
using test.Components;
using test.Resources.Styles;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;

namespace test
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiReactorApp<HomePage>(app =>
                {
                    app.UseTheme<ApplicationTheme>();
                },
                unhandledExceptionAction: e => 
                {
                    System.Diagnostics.Debug.WriteLine(e.ExceptionObject);
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            return builder.Build();
        }
    }
}
