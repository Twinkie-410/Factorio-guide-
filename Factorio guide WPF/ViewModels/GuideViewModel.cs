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
            var path = @"..\Resources\Article\Тестовая статья\";
            var testArticle_images = new List<BitmapImage>
                {new BitmapImage(new Uri($"{path}RG.png", UriKind.Relative))};
            var stream = new StreamReader($@"..\..\{path}Тестовая статья.txt");
            var stream1 = new StreamReader($@"..\..\{path}Тестовая статья.txt");
            var article = new Article(stream, testArticle_images) {Title = "статья1"};
            var article1 = new Article(stream1, testArticle_images) {Title = "статья2"};
            articles.Add(article);
            articles.Add(article1);

            Guide = articles;
        }
    }
}