using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using SampleMe.Models;
using SampleMe.Services;
using Prism.Mvvm;
using Prism.Navigation;

namespace SampleMe.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware, IDestructible
    {
        public string Title { get; set; }
        public bool IsBusy { get; set; }

        protected readonly IBasePageService BasePageService;
        protected readonly INavigationService NavigationService;
        protected readonly IDataStore<Item> DataStore;

        public BaseViewModel(IBasePageService basePageService)
        {
            NavigationService = basePageService.NavigationService;
            DataStore = basePageService.DataStore;
        }

        public virtual void Destroy()
        {
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters) { }

        public virtual void OnNavigatedTo(INavigationParameters parameters) { }

        public virtual void OnNavigatingTo(INavigationParameters parameters) { }
    }
}
