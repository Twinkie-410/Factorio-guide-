using System;
using Factorio_guide_WPF.ViewModels;

namespace Factorio_guide_WPF.Stores
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChanged;

        private ViewModelBase currentViewViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => currentViewViewModel;
            set
            {
                currentViewViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}