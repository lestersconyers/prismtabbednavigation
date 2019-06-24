using System;
using SampleMe.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleMe.Views
{
    public partial class AboutPage : ContentPage
    {
        AboutViewModel ViewModel;

        public AboutPage()
        {
            InitializeComponent();

            ViewModel = BindingContext as AboutViewModel;

            GoButton.SetBinding(Button.CommandProperty, nameof(ViewModel.GoOneLevelDeeperCommand));
            GoWithCodeBehind.SetBinding(Button.CommandProperty, nameof(ViewModel.GoOneLevelDeeperWithPageCommand));
        }


    }
}