using System;
using System.Windows.Input;
using Prism.Common;
using Prism.Navigation;
using SampleMe.Services;
using SampleMe.Views;
using Xamarin.Forms;

namespace SampleMe.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel(IBasePageService basePageService)
            : base(basePageService)
        {
            Title = "About";

            GoOneLevelDeeperCommand = new Command(Navigate);
            GoOneLevelDeeperWithPageCommand = new Command(NavigateWithPage);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            var d = DataStore;
        }

        public ICommand GoOneLevelDeeperCommand { get; }
        public ICommand GoOneLevelDeeperWithPageCommand { get; }

        private async void Navigate()
        {
            await NavigationService.NavigateAsync(nameof(OneLevelDeeper));
        }

        private async void NavigateWithPage()
        {
            try
            {
                var page = ((IPageAware)NavigationService).Page;
                var cp = page as ContentPage;

                await cp.Navigation.PushAsync(new OneLevelDeeper());
            }
            catch(Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}