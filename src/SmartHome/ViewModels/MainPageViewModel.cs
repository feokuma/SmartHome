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

        public ICommand NextPageCommand { get; }
        public ObservableRangeCollection<string> textos { get; set; }
        public MainPageViewModel(INavigationService navigationService)
        {
            NextPageCommand = new Command(NextPage);
            this.navigationService = navigationService;
            textos = new ObservableRangeCollection<string>();
            textos.AddRange(new string[] { "Texto 1", "Texto 2", "Texto 3"});
        }

        public async void NextPage()
        {
        }
    }
}
