using System;
using Prism.Commands;
using SampleMe.Services;
using SampleMe.Views;

namespace SampleMe.ViewModels
{
    public class ItemsLandingPageViewModel : BaseViewModel
    {
        public DelegateCommand OpenListCommand { get; }
        public ItemsLandingPageViewModel(IBasePageService basePageService)
            : base(basePageService)
        {
            OpenListCommand = new DelegateCommand(OpenList);
        }

        async void OpenList()
        {
            await NavigationService.NavigateAsync(nameof(ItemsPage));
        }
    }
}
