using System.Net.NetworkInformation;
using System.Windows.Input;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Stores;

namespace Factorio_guide_WPF.ViewModels
{
    public class RecipesViewModel : ViewModelBase
    {
        public ICommand NavigateMainMenuCommand { get; }
        public ICommand NavigateLogisticCommand { get; }
        public ICommand NavigateProductionCommand { get; }
        public ICommand NavigateIntermediateProductsCommand { get; }
        public ICommand NavigateCombatCommand { get; }

        public RecipesViewModel(NavigationStore navigationStore, EntityStore entityStore)
        {
            NavigateMainMenuCommand = new NavigateCommand<MainMenuViewModel>(navigationStore, () => new MainMenuViewModel(navigationStore, entityStore));
            NavigateLogisticCommand = new NavigateCommand<LogisticViewModel>(navigationStore, () => new LogisticViewModel(navigationStore, entityStore));
            NavigateProductionCommand = new NavigateCommand<ProductionViewModel>(navigationStore,
                () => new ProductionViewModel(navigationStore, entityStore));
            NavigateIntermediateProductsCommand = new NavigateCommand<IntermediateProductsViewModel>(navigationStore,
                () => new IntermediateProductsViewModel(navigationStore, entityStore));
            NavigateCombatCommand =
                new NavigateCommand<CombatViewModel>(navigationStore, () => new CombatViewModel(navigationStore, entityStore));
        }
    }
}