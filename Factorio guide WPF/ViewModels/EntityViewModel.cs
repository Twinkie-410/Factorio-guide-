using System.Windows.Input;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Models;
using Factorio_guide_WPF.Stores;

namespace Factorio_guide_WPF.ViewModels
{
    public class EntityViewModel : ViewModelBase
    {
        public Entity Entity { get; }
        public ICommand NavigateLogisticCommand { get; }

        public EntityViewModel(NavigationStore navigationStore, Entity entity)
        {
            NavigateLogisticCommand =
                new NavigateCommand<LogisticViewModel>(navigationStore, () => new LogisticViewModel(navigationStore));
            Entity = entity;
        }
    }
}