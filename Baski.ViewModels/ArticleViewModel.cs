using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Baski.Configuration;
using Baski.Helpers;
using Baski.Orm.Models;
using HtmlAgilityPack;

namespace Baski.ViewModels
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public MvcHtmlString Date { get; set; }
        public string VideoUrl { get; set; }
        public string ImageUrl { get; set; }
        
        public IEnumerable<string> Paragraphs { get; set; }

        public bool HasVideo
        {
            get { return !string.IsNullOrEmpty(VideoUrl); }
        }

        public bool HasImage
        {
            get { return !string.IsNullOrEmpty(ImageUrl); }
        }
        public ArticleViewModel(Article article)
        {
            Id = article.Id;
            Title = article.Title;
            Date = article.Date.FormatDateTime();
            if (!string.IsNullOrEmpty(article.VideoUrl))
            {
                VideoUrl = article.VideoUrl.GetEmbedYoutubeUrl();
            }
            ImageUrl = string.IsNullOrEmpty(article.ImageUrl) ? "": AppSettings.ArticlesImagesPath + article.ImageUrl;
            Paragraphs = article.Text.GetAllParagraphs();
        }
    }
}
