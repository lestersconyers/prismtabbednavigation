using System;
using SampleMe.Services;

namespace SampleMe.ViewModels
{
    public class OneLevelDeeperViewModel : BaseViewModel
    {
        public OneLevelDeeperViewModel(IBasePageService basePageService)
            : base(basePageService)
        {
            Title = "One Level Deeper";
        }
    }
}
