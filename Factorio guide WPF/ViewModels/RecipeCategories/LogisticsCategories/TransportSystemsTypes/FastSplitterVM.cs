using System.IO;
using System.Windows.Input;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Stores;

namespace Factorio_guide_WPF.ViewModels.RecipeCategories.LogisticsCategories.TransportSystemsTypes
{
    public class FastSplitterVM: ViewModelBase
    {
        public ICommand NavigateLogisticCommand { get; }

        public string GetDescription
        {
            get
            {
                using (var description =
                       new StreamReader(@"..\..\..\Resources\Logistics description\Transport systems description\Fast splitter.txt"))
                    return description.ReadToEnd();
            }
        }

        public FastSplitterVM(NavigationStore navigationStore)
        {
            NavigateLogisticCommand = new NavigateCommand<LogisticViewModel>(navigationStore, () => new LogisticViewModel(navigationStore));
        }
    }
}