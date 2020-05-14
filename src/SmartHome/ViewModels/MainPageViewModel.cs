using MvvmHelpers;
using Prism.Navigation;
using SmartHome.Enums;
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
                    AmbientIcon = Ambient.AmbientIconsDictionary[AmbientIconsEnum.MainBedroom]
                },
                new Ambient
                {
                    Temperature = "21º C",
                    Humidity = "20%",
                    Title = "Bathroom",
                    AmbientIcon = Ambient.AmbientIconsDictionary[AmbientIconsEnum.BathRoom]
                },
                new Ambient
                {
                    Temperature = "20º C",
                    Humidity = "12%",
                    Title = "Main bedroom",
                },
                new Ambient
                {
                    Temperature = "20º C",
                    Humidity = "12%",
                    Title = "Main bedroom",
                },
                new Ambient
                {
                    Temperature = "20º C",
                    Humidity = "12%",
                    Title = "Main bedroom",
                }
            };
        }
    }
}
