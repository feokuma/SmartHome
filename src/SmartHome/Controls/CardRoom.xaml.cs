using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHome.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardRoom : ContentView
    {
        public readonly static BindableProperty TitleProperty = BindableProperty.Create(
            "Title",
            typeof(string),
            typeof(CardRoom),
            string.Empty);

        public readonly static BindableProperty HumidityProperty = BindableProperty.Create(
            "Humidity",
            typeof(string),
            typeof(CardRoom),
            string.Empty);

        public readonly static BindableProperty TemperatureProperty = BindableProperty.Create(
            "Temperature",
            typeof(string),
            typeof(CardRoom),
            string.Empty);

        public string Title
        {
            get => GetValue(TitleProperty) as string;
            set => SetValue(TitleProperty, value);
        }

        public string Humidity
        {
            get => GetValue(HumidityProperty) as string;
            set => SetValue(HumidityProperty, value);
        }

        public string Temperature
        {
            get => GetValue(TemperatureProperty) as string;
            set => SetValue(TemperatureProperty, value);
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TitleProperty.PropertyName)
                title.Text = Title;
            else if (propertyName == HumidityProperty.PropertyName)
                humidity.Text = Humidity;
            else if (propertyName == TemperatureProperty.PropertyName)
                temperature.Text = Temperature;
        }

        public CardRoom()
        {
            InitializeComponent();
        }

        private void canvasView_PaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            using (SKPaint paint = new SKPaint())
            {
                // Create gradient for background
                paint.Shader = SKShader.CreateLinearGradient(
                                    new SKPoint(0, 0),
                                    new SKPoint(info.Width, info.Height),
                                    new SKColor[] { new SKColor(0x7a, 0x53, 0xcb),
                                                new SKColor(0xf5, 0x42, 0x8d) },
                                    null,
                                    SKShaderTileMode.Clamp);

                // Draw background
                canvas.DrawRect(info.Rect, paint);
            }
        }
    }
}