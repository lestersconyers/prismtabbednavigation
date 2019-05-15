using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SampleMe.Services;
using SampleMe.Views;
using Prism.DryIoc;
using Prism;
using Prism.Navigation;
using Prism.Ioc;
using SampleMe.ViewModels;
using SampleMe.Models;

namespace SampleMe
{
    public partial class App : PrismApplication
    {

        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"/{nameof(SplashPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<AboutPage, AboutViewModel>();
            containerRegistry.RegisterForNavigation<ItemDetailPage, ItemDetailViewModel>();
            containerRegistry.RegisterForNavigation<ItemsPage, ItemsViewModel>();
            containerRegistry.RegisterForNavigation<SplashPage, SplashPageViewModel>();
            containerRegistry.RegisterForNavigation<OneLevelDeeper, OneLevelDeeperViewModel>();

            containerRegistry.RegisterSingleton<IDataStore<Item>, MockDataStore>();
            containerRegistry.RegisterSingleton<IBasePageService, BasePageService>();
        }
    }
}
