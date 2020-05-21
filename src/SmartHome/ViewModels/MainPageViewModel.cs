using MvvmHelpers;
using Prism.Navigation;
using SmartHome.Models;

namespace SmartHome.ViewModels
{
    public class MainPageViewModel
    {
        private readonly INavigationService navigationService;

        public ObservableRangeCollection<Ambient> Ambients { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            Ambients = new ObservableRangeCollection<Ambient>
            {
                new Ambient
                {
                    Temperature = "25º C",
                    Humidity = "18%",
                    Title = "Main bedroom",
                    AmbientIcon = Ambient.AmbientIconsDictionary[AmbientEnum.MainBedroom],
                    AmbientImage = Ambient.AmbientImageDictionary[AmbientEnum.MainBedroom]
                },
                new Ambient
                {
                    Temperature = "21º C",
                    Humidity = "20%",
                    Title = "Bathroom",
                    AmbientIcon = Ambient.AmbientIconsDictionary[AmbientEnum.BathRoom],
                    AmbientImage = Ambient.AmbientImageDictionary[AmbientEnum.BathRoom]
                },
                new Ambient
                {
                    Temperature = "20º C",
                    Humidity = "12%",
                    Title = "Living room",
                    AmbientImage = Ambient.AmbientImageDictionary[AmbientEnum.LivingRoom]
                },
                new Ambient
                {
                    Temperature = "20º C",
                    Humidity = "12%",
                    Title = "Kitchen",
                    AmbientImage = Ambient.AmbientImageDictionary[AmbientEnum.Kitchen]
                },
                new Ambient
                {
                    Temperature = "20º C",
                    Humidity = "12%",
                    Title = "Garage",
                    AmbientImage = Ambient.AmbientImageDictionary[AmbientEnum.Garage]
                }
            };
        }
    }
}
