using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using SampleMe.Models;
using SampleMe.Views;
using SampleMe.Services;
using Prism.Commands;
using Prism.Navigation;

namespace SampleMe.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Items { get; set; }
        public DelegateCommand LoadItemsCommand { get; set; }
        public DelegateCommand<Item> OpenDetailsCommand { get; }
        public DelegateCommand OpenAddItemCommand { get; }

        public ItemsViewModel(IBasePageService basePageService)
            : base(basePageService)
        {
            Title = "Browse";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new DelegateCommand(ExecuteLoadItemsCommand);

            OpenDetailsCommand = new DelegateCommand<Item>(OpenDetails);
            OpenAddItemCommand = new DelegateCommand(OpenAddItem);

            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });
        }

        private async void OpenDetails(Item item)
        {
            var parameters = new NavigationParameters() { {"Item", item }};
            await NavigationService.NavigateAsync(nameof(ItemDetailPage), parameters);
        }

        private async void OpenAddItem()
        {
            //do nothing for now...
        }

        async void ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            ExecuteLoadItemsCommand();
        }
    }
}