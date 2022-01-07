namespace MauiApp1;

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
            })
            .ConfigureMauiHandlers(handlers =>
            {
                handlers.AddHandler(
                    typeof(MySkiaView),
                    typeof(SkiaSharp.Views.Maui.Handlers.SKCanvasViewHandler)
                    );
            });

        return builder.Build();
    }
}
