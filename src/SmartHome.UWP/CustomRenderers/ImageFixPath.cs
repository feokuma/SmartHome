using SmartHome.UWP.CustomRenderers;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(Image), typeof(ImageFixPath))]
namespace SmartHome.UWP.CustomRenderers
{
    public class ImageFixPath : ImageRenderer
    {
        bool _disposed;

        private string _imagePrefix = @"Resources\Images\";

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            _disposed = true;
        }

        protected override async Task TryUpdateSource()
        {
            // By default we'll just catch and log any exceptions thrown by UpdateSource so we don't bring down
            // the application; a custom renderer can override this method and handle exceptions from
            // UpdateSource differently if it wants to

            try
            {
                await UpdateSource2().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Log.Warning(nameof(ImageRenderer), "Error loading image: {0}", ex);
            }
            finally
            {
                ((IImageController)Element)?.SetIsLoading(false);
            }
        }

        private void TryFixSourcePath(ImageSource source)
        {
            if (source is FileImageSource fileSource)
            {
                // var fileSource = source as FileImageSource;
                if (fileSource != null)
                {
                    var filePath = fileSource.File;
                    if (!filePath.StartsWith(_imagePrefix))
                        filePath = _imagePrefix + filePath;
                    if (!filePath.EndsWith(".png"))
                        filePath += ".png";

                    if (filePath != fileSource.File)
                        fileSource.File = filePath;
                }
            }
        }

        protected async Task UpdateSource2()
        {
            if (_disposed || Element == null || Control == null)
            {
                return;
            }

            Element.SetIsLoading(true);

            ImageSource source = Element.Source;
            TryFixSourcePath(source);

            IImageSourceHandler handler;
            if (source != null && (handler = Registrar.Registered.GetHandler<IImageSourceHandler>(source.GetType())) != null)
            {
                Windows.UI.Xaml.Media.ImageSource imagesource;

                try
                {
                    imagesource = await handler.LoadImageAsync(source);
                }
                catch (OperationCanceledException)
                {
                    imagesource = null;
                }

                // In the time it takes to await the imagesource, some zippy little app
                // might have disposed of this Image already.
                if (Control != null)
                {
                    Control.Source = imagesource;
                }

                RefreshImage();
            }
            else
            {
                Control.Source = null;
                Element.SetIsLoading(false);
            }
        }

        void RefreshImage()
        {
            ((IVisualElementController)Element)?.InvalidateMeasure(InvalidationTrigger.RendererReady);
        }
    }
}
