using System;
using Prism.Navigation;
using SampleMe.Models;

namespace SampleMe.Services
{
    public interface IBasePageService
    {
        INavigationService NavigationService { get; }
        IDataStore<Item> DataStore { get; }
    }
}
