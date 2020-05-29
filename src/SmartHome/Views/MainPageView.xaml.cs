using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartHome.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPageView : ContentPage
    {
        public MainPageView()
        {
            InitializeComponent();
        }

        private void skiaCanvas_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs args)
        {
            var imageInfo = args.Info;
            var surface = args.Surface;
            var canvas = surface.Canvas;
            var initialColor = new SKColor(0x7a, 0x53, 0xcb);
            var finalColor = new SKColor(0xf5, 0x42, 0x8d);

            canvas.Clear();

            using (SKPaint paint = new SKPaint())
            {
                // Create gradient for background
                paint.Shader = SKShader.CreateLinearGradient(
                                    new SKPoint(0, 0),
                                    new SKPoint(imageInfo.Width/2, imageInfo.Height/2),
                                    new SKColor[] { initialColor, finalColor },
                                    null,
                                    SKShaderTileMode.Clamp);

                var point = new SKPoint(imageInfo.Width/2,imageInfo.Height/2);
                // Draw background
                canvas.DrawCircle(point,imageInfo.Width/2, paint);
            }
        }
    }
}
