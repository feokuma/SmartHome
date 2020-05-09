using MvvmHelpers;
using Prism.Navigation;
using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SmartHome.ViewModels
{
    public class MainPageViewModel
    {
        private readonly INavigationService navigationService;

        public ObservableCollection<Ambient> Ambients { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            Ambients = new ObservableCollection<Ambient>
            {
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
