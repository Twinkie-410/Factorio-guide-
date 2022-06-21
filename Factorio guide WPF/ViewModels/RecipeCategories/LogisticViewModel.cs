using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Factorio_guide__WPF;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Stores;
using Factorio_guide_WPF.ViewModels.RecipeCategories.LogisticsCategories.StorageTypes;
using Factorio_guide_WPF.ViewModels.RecipeCategories.LogisticsCategories.TransportSystemsTypes;
using Factorio_guide_WPF.Views.RecipeCategories.LogisticsCategories.Belt_transport_system;

namespace Factorio_guide_WPF.ViewModels
{
    public class LogisticViewModel : ViewModelBase
    {
        public ICommand NavigateRecipesCommand { get; }

        #region NavigateEntityCommand

        #region LogisticEntityCommand

        #region StorageEntityCommand

        public ICommand NavigateWoodenChest { get; private set; }
        public ICommand NavigateIronChest { get; private set; }
        public ICommand NavigateSteelChest { get; private set; }
        public ICommand NavigateStorageTank { get; private set; }

        #endregion

        #region BeltTransportSustemsCommand

        public ICommand NavigateTransportBelt { get; private set; }
        public ICommand NavigateFastTransportBelt { get; private set; }
        public ICommand NavigateExpressTransportBelt { get; private set; }
        public ICommand NavigateUndergroundBelt { get; private set; }
        public ICommand NavigateFastUndergroundBelt { get; private set; }
        public ICommand NavigateExpressUndergroundBelt { get; private set; }
        public ICommand NavigateSplitter { get; private set; }
        public ICommand NavigateFastSplitter { get; private set; }
        public ICommand NavigateExpressSplitter { get; private set; }

        #endregion
        #endregion

        #endregion

        public LogisticViewModel(NavigationStore navigationStore)
        {
            NavigateRecipesCommand =
                new NavigateCommand<RecipesViewModel>(navigationStore, () => new RecipesViewModel(navigationStore));
            CreateNavigateEntityCommand(navigationStore);
        }

        private void CreateNavigateEntityCommand(NavigationStore navigationStore)
        {
            CreateLogisticEntity(navigationStore);
        }

        private void CreateLogisticEntity(NavigationStore navigationStore)
        {
            CreateStores(navigationStore);
            CreateBeltTransportSystems(navigationStore);
            CreateInserters(navigationStore);
        }

        private void CreateInserters(NavigationStore navigationStore)
        {
            
        }

        private void CreateBeltTransportSystems(NavigationStore navigationStore)
        {
            NavigateTransportBelt = new NavigateCommand<TransportBeltVM>(navigationStore,
                () => new TransportBeltVM(navigationStore));
            NavigateFastTransportBelt = new NavigateCommand<FastTransportBeltVM>(navigationStore,
                () => new FastTransportBeltVM(navigationStore));
            NavigateExpressTransportBelt = new NavigateCommand<ExpressTransportBeltVM>(navigationStore,
                () => new ExpressTransportBeltVM(navigationStore));
            NavigateUndergroundBelt = new NavigateCommand<UndergroundBeltVM>(navigationStore,
                () => new UndergroundBeltVM(navigationStore));
            NavigateFastUndergroundBelt = new NavigateCommand<FastUndergroundBeltVM>(navigationStore,
                () => new FastUndergroundBeltVM(navigationStore));
            NavigateExpressUndergroundBelt = new NavigateCommand<ExpressUndergroundBeltVM>(navigationStore,
                () => new ExpressUndergroundBeltVM(navigationStore));
            NavigateSplitter = new NavigateCommand<SplitterVM>(navigationStore,
                () => new SplitterVM(navigationStore));
            NavigateFastSplitter = new NavigateCommand<FastSplitterVM>(navigationStore,
                () => new FastSplitterVM(navigationStore));
            NavigateExpressSplitter = new NavigateCommand<ExpressSplitterVM>(navigationStore,
                () => new ExpressSplitterVM(navigationStore));
        }

        private void CreateStores(NavigationStore navigationStore)
        {
            NavigateWoodenChest = new NavigateCommand<WoodenChestVM>(navigationStore,
                () => new WoodenChestVM(navigationStore));
            NavigateIronChest = new NavigateCommand<IronChestVM>(navigationStore,
                () => new IronChestVM(navigationStore));
            NavigateSteelChest = new NavigateCommand<SteelChestVM>(navigationStore,
                () => new SteelChestVM(navigationStore));
            ;
            NavigateStorageTank = new NavigateCommand<StorageTankVM>(navigationStore,
                () => new StorageTankVM(navigationStore));
        }
    }
}