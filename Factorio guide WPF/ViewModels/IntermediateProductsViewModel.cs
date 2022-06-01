using System.Windows.Input;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Stores;

namespace Factorio_guide_WPF.ViewModels
{
    public class IntermediateProductsViewModel : ViewModelBase
    {
        public ICommand NavigateRecipesCommand { get; }
        

        public IntermediateProductsViewModel(NavigationStore navigationStore, EntityStore entityStore)
        {
            NavigateRecipesCommand = new NavigateCommand<RecipesViewModel>(navigationStore, () => new RecipesViewModel(navigationStore, entityStore)); 
        }
    }
}