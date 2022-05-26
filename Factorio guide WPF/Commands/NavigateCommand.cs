using System;
using Factorio_guide_WPF.Stores;
using Factorio_guide_WPF.ViewModels;

namespace Factorio_guide_WPF.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase 
        where TViewModel : ViewModelBase
    {
        private readonly NavigationStore navigationStore;
        private readonly Func<TViewModel> createViewModel;

        public NavigateCommand(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            this.navigationStore = navigationStore; 
            this.createViewModel = createViewModel;
        }

        public override void Execute(object parameter)
        {
            navigationStore.CurrentViewModel = createViewModel();
        }

    }
}