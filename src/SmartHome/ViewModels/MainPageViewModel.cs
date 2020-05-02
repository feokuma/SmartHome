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

        public ICommand NextPageCommand { get; }
        public MainPageViewModel(INavigationService navigationService)
        {
            NextPageCommand = new Command(NextPage);
            this.navigationService = navigationService;
        }

        public async void NextPage()
        {
            await DisplayAlert("Alert", "You have been alerted", "Ok");
        }
    }
}
