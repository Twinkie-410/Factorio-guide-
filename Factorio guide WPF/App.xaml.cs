using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Factorio_guide_WPF.Stores;
using Factorio_guide_WPF.ViewModels;
using Factorio_guide_WPF.Views;

namespace Factorio_guide_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var navigationStore = new NavigationStore();
            navigationStore.CurrentViewModel = new MainMenuViewModel(navigationStore);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();
            
            base.OnStartup(e);
        }
    }
}