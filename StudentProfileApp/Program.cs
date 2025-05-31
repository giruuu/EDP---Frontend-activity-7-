using Avalonia;
using System;

namespace StudentProfileAvaloniaApp
{
    class Program
    {
        public static void Main(string[] args) =>
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                         .UsePlatformDetect()
                         .LogToTrace();
    }
}