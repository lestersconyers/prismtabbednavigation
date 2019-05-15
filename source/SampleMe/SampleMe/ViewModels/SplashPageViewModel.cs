using System;
using System.Threading.Tasks;
using Prism.Navigation;
using SampleMe.Services;
using Xamarin.Forms;

namespace SampleMe.ViewModels
{
    public class SplashPageViewModel : BaseViewModel
    {
        public SplashPageViewModel(IBasePageService basePageService)
            : base(basePageService)
        {

        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            //simulate a wait period
            await Task.Delay(1000);

            //this is the page with tabs
            await NavigationService.NavigateAsync($"/MainPage");
            //await NavigationService.NavigateAsync("/MainPage?selectedTab=ItemsPage");
        }
    }
}

