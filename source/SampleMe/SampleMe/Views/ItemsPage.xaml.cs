using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SampleMe.Models;
using SampleMe.Views;
using SampleMe.ViewModels;
using Prism.Behaviors;

namespace SampleMe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsViewModel ViewModel { get; }

        public ItemsPage()
        {
            InitializeComponent();

            ViewModel = BindingContext as ItemsViewModel;

            SetBindings();
        }

        void SetBindings()
        {
            ItemsListView.Behaviors.Add(new EventToCommandBehavior
            {
                EventName = "ItemTapped",
                Command = ViewModel.OpenDetailsCommand,
                EventArgsParameterPath = "Item"
            });

        }
    }
}