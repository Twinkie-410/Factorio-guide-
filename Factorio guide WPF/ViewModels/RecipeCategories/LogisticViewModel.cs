using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Factorio_guide__WPF;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Stores;
using Factorio_guide_WPF.ViewModels.RecipeCategories.LogisticsCategories.StorageTypes;

namespace Factorio_guide_WPF.ViewModels
{
    public class LogisticViewModel : ViewModelBase
    {
        public ICommand NavigateRecipesCommand { get; }

        #region NavigateEntityCommand
        public ICommand NavigateWoodenChest { get; private set; }
        public ICommand NavigateIronChest { get; private set; }
        public ICommand NavigateSteelChest { get; private set; }
        public ICommand NavigateStorageTank { get; private set; }
        #endregion

        public LogisticViewModel(NavigationStore navigationStore)
        {
            NavigateRecipesCommand = new NavigateCommand<RecipesViewModel>(navigationStore, () => new RecipesViewModel(navigationStore));
            CreateNavigateEntityCommand(navigationStore);
        }

        private void CreateNavigateEntityCommand(NavigationStore navigationStore)
        {
            var logisticEntity = CreateLogisticEntity();
            NavigateWoodenChest = new NavigateCommand<WoodenChestVM>(navigationStore,
                () => new WoodenChestVM(navigationStore));
            NavigateIronChest = new NavigateCommand<EntityViewModel>(navigationStore,
                () => new EntityViewModel(navigationStore, logisticEntity["Железный сундук"]));
            NavigateSteelChest = new NavigateCommand<EntityViewModel>(navigationStore,
                () => new EntityViewModel(navigationStore, logisticEntity["Стальной сундук"]));
            NavigateStorageTank = new NavigateCommand<EntityViewModel>(navigationStore,
                () => new EntityViewModel(navigationStore, logisticEntity["Резервуар"]));
        }

        private Dictionary<string, Logistics> CreateLogisticEntity()
        {
            var logisticEntities = new Dictionary<string, Logistics>();

            var stores = CreateStores();
            // var beltTransportSystems = CreateBeltTransportSustems();
            // var inserters = CreateInsrters();
            
            foreach(var store in stores)
                logisticEntities.Add(store.Name, store);
            return logisticEntities;
        }

        private object CreateInsrters()
        {
            throw new System.NotImplementedException();
        }

        private object CreateBeltTransportSustems()
        {
            throw new System.NotImplementedException();
        }

        private Collection<Storage> CreateStores()
        {
            var collection = new Collection<Storage>();
            var woodenChest = new Storage("Деревянный сундук", null, new Recipe(0.5), new TotalRaw(0.5), 16, 100, 
                new Size(1, 1));
            var ironChest = new Storage("Железный сундук", null, new Recipe(0.5), new TotalRaw(0.5), 32, 200,
                new Size(1, 1));
            var steelChest = new Storage("Стальной сундук", null, new Recipe(0.5), new TotalRaw(0.5), 48, 350,
                new Size(1, 1));
            var storageTank = new Storage("Резервуар", null, new Recipe(3), new TotalRaw(3), 25000, 500,
                new Size(3, 3));
            
            collection.Add(woodenChest);
            collection.Add(ironChest);
            collection.Add(steelChest);
            collection.Add(storageTank);

            return collection;
        }
    }
}