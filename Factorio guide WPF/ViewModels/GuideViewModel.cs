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
    public class GuideViewModel : ViewModelBase
    {
        public List<Article> Guide { get; set; }
        public ICommand NavigateMainMenuCommand { get; }

        public GuideViewModel(NavigationStore navigationStore)
        {
            NavigateMainMenuCommand = new NavigateCommand<MainMenuViewModel>(navigationStore, () => new MainMenuViewModel(navigationStore));
            CreateArticle();
        }

        private void CreateArticle()
        {
            var articles = new List<Article>();
            var path = @"..\Resources\Article\Гайды\Массовое производство\";
            var path1 = @"..\Resources\Article\Гайды\Электричество\";
            var massFrom1 = new Article(new StreamReader(@$"..\..\{path}На 1 ресурс.txt"),
                new List<BitmapImage> {new BitmapImage(new Uri($"{path}На 1 ресурс.jpg", UriKind.Relative))});
            var massFrom2 = new Article(new StreamReader(@$"..\..\{path}На 2 ресурса.txt"),
                new List<BitmapImage> {new BitmapImage(new Uri($"{path}На 2 ресурса.jpg", UriKind.Relative))});
            var massFrom3 = new Article(new StreamReader(@$"..\..\{path}На 3 ресурса.txt"),
                new List<BitmapImage>
                {
                    new BitmapImage(new Uri($"{path}На 3 ресурса.jpg", UriKind.Relative)),
                    new BitmapImage(new Uri($"{path}На 3 ресурса(dsdjl).jpg", UriKind.Relative))
                });
            var massFrom4 = new Article(new StreamReader(@$"..\..\{path}На 4 ресурса.txt"),
                new List<BitmapImage> {new BitmapImage(new Uri($"{path}На 4 ресурса.jpg", UriKind.Relative))});
            var massFrom5 = new Article(new StreamReader(@$"..\..\{path}На 5 ресурсов.txt"),
                new List<BitmapImage> {new BitmapImage(new Uri($"{path}На 5 ресурсов.jpg", UriKind.Relative))});
            var electro = new Article(new StreamReader(@$"..\..\{path1}Электричество.txt"));


            articles.Add(electro);
            articles.Add(massFrom1);
            articles.Add(massFrom2);
            articles.Add(massFrom3);
            articles.Add(massFrom4);
            articles.Add(massFrom5);


            Guide = articles;
        }
    }
}