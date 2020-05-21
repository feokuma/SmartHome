using System;
using System.Globalization;
using System.Reflection;
using Xamarin.Forms;

namespace SmartHome.Converters
{
    public class ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var source = value as string;

            if (string.IsNullOrEmpty(source)) return string.Empty;

            var applicationTypeInfo = Application.Current.GetType().GetTypeInfo();
            var imageSourcePath = $"{applicationTypeInfo.Namespace}.Resources.Images.{source}.jpg";

            return ImageSource.FromResource(imageSourcePath, this.GetType().Assembly);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
