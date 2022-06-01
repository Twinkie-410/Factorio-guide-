using System;
using Factorio_guide_WPF.Models;
using Factorio_guide_WPF.Stores;
using Factorio_guide_WPF.ViewModels;

namespace Factorio_guide_WPF.Commands
{
    public class NavigateEntityCommand : CommandBase
    {
        //private readonly NavigationStore
        private readonly EntityStore entityStore;
        private readonly Func<EntityViewModel> createEntityViewModel;

        public NavigateEntityCommand(EntityStore entityStore, Func<EntityViewModel> createEntityViewModel)
        {
            this.entityStore = entityStore;
            this.createEntityViewModel = createEntityViewModel;
        }

        public override void Execute(object parameter)
        {
            entityStore.CurrentEntityViewModel = createEntityViewModel();
        }
    }
}