using System;
using Prism.Commands;
using Prism.Navigation;
using SampleMe.Models;
using SampleMe.Services;
using SampleMe.Views;

namespace SampleMe.ViewModels
{
    public class EditItemPageViewModel : BaseViewModel
    {
        public Item Item { get; private set; }
        public DelegateCommand SaveItemCommand { get; }

        public EditItemPageViewModel(IBasePageService basePageService)
            :base(basePageService)
        {
            Title = "Edit Item";
            SaveItemCommand = new DelegateCommand(SaveItem);
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            Item = parameters["Item"] as Item;
        }

        private async void SaveItem()
        {
            //pretend we're doing something...

            //navigate back to list
            //await NavigationService.NavigateAsync("/" + nameof(ItemsPage)); //sends back but removes toolbar and tabs

            //await NavigationService.NavigateAsync("/MainPage?selectedTab=ItemsPage"); //sends back to the landing page

            //await NavigationService.NavigateAsync("/MainPage?selectedTab=ItemsLandingPage/ItemsPage"); //this SHOULD work according to https://github.com/PrismLibrary/Prism/issues/1293

            await NavigationService.NavigateAsync("../../");
        }
    }
}
