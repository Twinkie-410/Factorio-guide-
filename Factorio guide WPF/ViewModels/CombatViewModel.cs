using System.Windows.Input;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Stores;

namespace Factorio_guide_WPF.ViewModels
{
    public class CombatViewModel : ViewModelBase
    {
        public ICommand NavigateRecipesCommand { get; }
        

        public CombatViewModel(NavigationStore navigationStore)
        {
            NavigateRecipesCommand = new NavigateCommand<RecipesViewModel>(navigationStore, () => new RecipesViewModel(navigationStore)); 
        }
    }
}