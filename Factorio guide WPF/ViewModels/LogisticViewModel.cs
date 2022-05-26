using System.Windows.Input;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Stores;

namespace Factorio_guide_WPF.ViewModels
{
    public class LogisticViewModel : ViewModelBase
    {
        public ICommand NavigateRecipesCommand { get; }
        

        public LogisticViewModel(NavigationStore navigationStore)
        {
            NavigateRecipesCommand = new NavigateCommand<RecipesViewModel>(navigationStore, () => new RecipesViewModel(navigationStore)); 
        }
    }
}