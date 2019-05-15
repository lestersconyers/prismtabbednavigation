using System;
using System.Windows.Input;
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
        }

        public ICommand GoOneLevelDeeperCommand { get; }

        private async void Navigate()
        {
            await NavigationService.NavigateAsync("../" + nameof(OneLevelDeeper));
        }
    }
}