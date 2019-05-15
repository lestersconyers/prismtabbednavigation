using System;
using Prism.Navigation;
using SampleMe.Models;
using SampleMe.Services;

namespace SampleMe.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }

        public ItemDetailViewModel(IBasePageService basePageService)
            :base(basePageService)
        {
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            Item = parameters["item"] as Item;
            Title = Item?.Text;
        }
    }
}
