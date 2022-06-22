using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Imaging;

namespace Factorio_guide_WPF.Models.Materials_and_Recipes.Article
{
    public class Article
    {
        public string Title { get; set; }
        private StreamReader Content;
        private List<BitmapImage> Images;

        public string GetText
        {
            get => StreamToText();
        }
        
        public List<BitmapImage> GetImage
        {
            get =>  Images;
        }
        
        public Article(StreamReader content, List<BitmapImage> images = null, string title = null)
        {
            Content = content;
            Images = images;
            Title = content != null ? content.ReadLine() : title;
        }

        private string StreamToText()
        {
            using (Content)
                return Content.ReadToEnd();
        }
    }
}