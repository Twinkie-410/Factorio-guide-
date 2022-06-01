using System.Windows.Input;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Stores;

namespace Factorio_guide_WPF.ViewModels
{
    public class MainMenuViewModel : ViewModelBase
    {
        public ICommand NavigateRecipesCommand { get; }
        public ICommand NavigateLiveHackCommand { get; }
        public ICommand NavigateGuideCommand { get; }
        public ICommand NavigateFaqCommand { get; }

        public MainMenuViewModel(NavigationStore navigationStore, EntityStore entityStore)
        {
            NavigateRecipesCommand = new NavigateCommand<RecipesViewModel>(navigationStore, () => new RecipesViewModel(navigationStore, entityStore));
            NavigateLiveHackCommand = new NavigateCommand<LiveHackViewModel>(navigationStore, () => new LiveHackViewModel(navigationStore, entityStore));
            NavigateGuideCommand = new NavigateCommand<GuideViewModel>(navigationStore, () => new GuideViewModel(navigationStore, entityStore));
            NavigateFaqCommand = new NavigateCommand<FAGViewModel>(navigationStore, () => new FAGViewModel(navigationStore, entityStore));
        }
    }
}