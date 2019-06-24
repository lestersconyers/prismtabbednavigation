using System;
using Prism.Commands;
using Prism.Navigation;
using SampleMe.Models;
using SampleMe.Services;
using SampleMe.Views;

namespace SampleMe.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; private set; }
        public DelegateCommand OpenEditCommand { get; }

        public ItemDetailViewModel(IBasePageService basePageService)
            : base(basePageService)
        {
            OpenEditCommand = new DelegateCommand(OpenEdit);
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            Item = parameters["Item"] as Item;
            Title = Item?.Text;
        }

        private async void OpenEdit()
        {
            var parameters = new NavigationParameters() { { "Item", Item } };
            await NavigationService.NavigateAsync(nameof(EditItemPage), parameters);
        }
    }
}
