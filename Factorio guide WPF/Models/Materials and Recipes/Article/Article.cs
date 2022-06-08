﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Factorio_guide_WPF;

namespace Factorio_guide__WPF.Guide
{
    public class Article
    {
        private StreamReader Content;


        private List<BitmapImage> Images;

        public string GetText
        {
            get => StreamToText();
        }
        
        public BitmapImage GetImage
        {
            get =>  Images[0];
        }
        
        public Article(StreamReader content, List<BitmapImage> images)
        {
            Content = content;
            this.Images = images;
        }

        private string StreamToText()
        {
            using (Content)
                return Content.ReadToEnd();
        }
    }
}