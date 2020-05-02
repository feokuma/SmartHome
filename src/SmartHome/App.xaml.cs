using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using SmartHome.ViewModels;
using SmartHome.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHome
{
    public partial class App : PrismApplication
    {
        public App() : base(null) { }

        public App(IPlatformInitializer initializer) : base(initializer, true) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/MainPageView");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPageView, MainPageViewModel>();
        }
    }
}
