using System.Windows.Input;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Models;
using Factorio_guide_WPF.Stores;

namespace Factorio_guide_WPF.ViewModels
{
    public class LogisticViewModel : ViewModelBase
    {
        public ICommand NavigateRecipesCommand { get; }

        #region NavigateEntityCommand
        public ICommand NavigateWoodenChest { get; private set; }
        public ICommand NavigateIronChest { get; }
        public ICommand NavigateSteelChest { get; }
        public ICommand NavigateStorageTank { get; }
        #endregion

        public LogisticViewModel(NavigationStore navigationStore, EntityStore entityStore)
        {
            NavigateRecipesCommand = new NavigateCommand<RecipesViewModel>(navigationStore, () => new RecipesViewModel(navigationStore, entityStore));
            CreateNavigateEntityCommand(navigationStore, entityStore);
        }

        private void CreateNavigateEntityCommand(NavigationStore navigationStore, EntityStore entityStore)
        {
            NavigateWoodenChest = new NavigateCommand<EntityViewModel>(navigationStore,
                () => new EntityViewModel(navigationStore, new Entity("Wooden Chest"), entityStore));
        }
    }
}