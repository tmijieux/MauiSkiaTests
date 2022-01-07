using SkiaSharp;
using SkiaSharp.Views.Maui;
using SkiaSharp.Views.Maui.Controls;

namespace MauiApp1;

public class MySkiaView : SKCanvasView
{
    public MySkiaView()
    {
        PaintSurface += MySkiaView_PaintSurface;
    }

    private void MySkiaView_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
    {
        var canvas = e.Surface.Canvas;
        var info = e.Info;
        Draw(info, canvas);
    }

    private void Draw(SKImageInfo info, SKCanvas canvas)
    {
        canvas.Clear();
        float radius = Math.Min(info.Width / 4, info.Height / 4);
        var middle = new SKPoint(info.Width / 2, info.Height / 2);
        using SKPaint paint = new()
        {
            Color = 0xFFFF0000,
            StrokeWidth = 10,
            Style = SKPaintStyle.Stroke
        };
        canvas.DrawCircle(middle, radius, paint);
    }
}