using MvvmHelpers;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SmartHome.ViewModels
{
    public class MainPageViewModel
    {
        private readonly INavigationService navigationService;

        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            Temperature = "20º C";
            Humidity = "12%";
            Title = "Main bedroom";
        }
    }
}
