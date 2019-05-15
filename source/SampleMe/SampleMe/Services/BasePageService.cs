using System;
using Prism.Navigation;
using SampleMe.Models;

namespace SampleMe.Services
{
    public class BasePageService : IBasePageService
    {
        readonly INavigationService _navigationService;
        readonly IDataStore<Item> _dataStore;

        public BasePageService(INavigationService navigationService, IDataStore<Item> dataStore)
        {
            _navigationService = navigationService;
        }

        public INavigationService NavigationService => _navigationService;
        public IDataStore<Item> DataStore => _dataStore;
    }
}
