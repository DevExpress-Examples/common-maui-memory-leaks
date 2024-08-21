﻿using TypicalMemoryLeaks.Pages;

namespace TypicalMemoryLeaks {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .RegisterViews()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("roboto-regular.ttf", "Roboto");
                    fonts.AddFont("roboto-medium.ttf", "Roboto-Medium");
                    fonts.AddFont("roboto-bold.ttf", "Roboto-Bold");
                });
            return builder.Build();
        }
        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder) {
            mauiAppBuilder.Services.AddSingleton<SinglegonPage>();

            //Use AddTransient to create SinglegonPage each time you navigate to it and don't keep it in the memmory
            //mauiAppBuilder.Services.AddTransient<SinglegonPage>();
            return mauiAppBuilder;
        }
    }
}