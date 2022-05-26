using System.Windows.Input;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Stores;

namespace Factorio_guide_WPF.ViewModels
{
    public class RecipesViewModel : ViewModelBase
    {
        public ICommand NavigateMainMenuCommand { get; }

        public RecipesViewModel(NavigationStore navigationStore)
        {
            NavigateMainMenuCommand = new NavigateCommand<MainMenuViewModel>(navigationStore, () => new MainMenuViewModel(navigationStore)); 
        }
    }
}