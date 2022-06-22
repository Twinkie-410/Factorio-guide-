using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Factorio_guide_WPF.Commands;
using Factorio_guide_WPF.Models.Materials_and_Recipes.Article;
using Factorio_guide_WPF.Stores;

namespace Factorio_guide_WPF.ViewModels
{
    public class FAGViewModel : ViewModelBase
    {
        public List<Article> Blueprints { get; set; }
        public ICommand NavigateMainMenuCommand { get; }

        public FAGViewModel(NavigationStore navigationStore)
        {
            NavigateMainMenuCommand = new NavigateCommand<MainMenuViewModel>(navigationStore, () => new MainMenuViewModel(navigationStore));
            CreateArticle();
        }

        private void CreateArticle()
        {
            var articles = new List<Article>();
            var path = @"..\Resources\Article\Схемы\";
            var path1 = @"..\Resources\Article\Гайды\Массовое производство\";
            var remeltingShop = new Article(null, 
                new List<BitmapImage>
                {
                    new BitmapImage(new Uri($"{path}Переплавляющий цех.jpg", UriKind.Relative)),
                    new BitmapImage(new Uri($"{path}Переплавляющий цех 1.jpg", UriKind.Relative))
                },
                "Переплавляющий цех");
            var universalProduction = new Article(null,
                new List<BitmapImage>
                {
                    new BitmapImage(new Uri($"{path1}На 1 ресурс.jpg", UriKind.Relative)),
                    new BitmapImage(new Uri($"{path1}На 2 ресурса.jpg", UriKind.Relative)),
                    new BitmapImage(new Uri($"{path1}На 3 ресурса.jpg", UriKind.Relative)),
                    new BitmapImage(new Uri($"{path1}На 3 ресурса(dsdjl).jpg", UriKind.Relative)),
                    new BitmapImage(new Uri($"{path1}На 4 ресурса.jpg", UriKind.Relative)),
                    new BitmapImage(new Uri($"{path1}На 5 ресурсов.jpg", UriKind.Relative))
                },
                "Универсальные производства на 1-5 ресурсов");

            articles.Add(remeltingShop);
            articles.Add(universalProduction);
            
            Blueprints = articles;
        }
    }
}