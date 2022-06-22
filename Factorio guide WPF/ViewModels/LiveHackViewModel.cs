using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Models.Materials_and_Recipes.Article;
using Factorio_guide_WPF.Stores;

namespace Factorio_guide_WPF.ViewModels
{
    public class LiveHackViewModel : ViewModelBase
    {
        public List<Article> LiveHacks { get; set; }
        public ICommand NavigateMainMenuCommand { get; }

        public LiveHackViewModel(NavigationStore navigationStore)
        {
            NavigateMainMenuCommand = new NavigateCommand<MainMenuViewModel>(navigationStore, () => new MainMenuViewModel(navigationStore));
            CreateArticle();
        }

        private void CreateArticle()
        {
            var articles = new List<Article>();
            var path = @"..\Resources\Article\Советы\";

            var peacefulRegime = new Article(new StreamReader(@$"..\..\{path}Мирный режим.txt"),
                new List<BitmapImage> {new BitmapImage(new Uri($"{path}Мирный режим.jpg", UriKind.Relative))});
            var quickExchange = new Article(new StreamReader(@$"..\..\{path}Быстрый обмен.txt"));
            var movingInventory = new Article(new StreamReader(@$"..\..\{path}Перемещение инвентаря.txt"));
            var rebuild = new Article(new StreamReader(@$"..\..\{path}Перестройка.txt"));
            var expansionInfo = new Article(new StreamReader(@$"..\..\{path}Расширенная информация.txt"));
            var electricityNetworkStatistics = new Article(new StreamReader(@$"..\..\{path}Статистика электросети.txt"));
            var smartStack = new Article(new StreamReader(@$"..\..\{path}Умный стек.txt"));

            
            articles.Add(peacefulRegime);
            articles.Add(quickExchange);
            articles.Add(movingInventory);
            articles.Add(rebuild);
            articles.Add(expansionInfo);
            articles.Add(electricityNetworkStatistics);
            articles.Add(smartStack);
            
            LiveHacks = articles;
        }
    }
}