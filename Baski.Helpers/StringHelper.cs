using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Mvc;
using HtmlAgilityPack;

namespace Baski.Helpers
{
    public static class StringHelper
    {
        public static MvcHtmlString ShortenText(this MvcHtmlString text)
        {
           /* string temp = text.ToString();
            if (text.ToString().Length > 50)
            {
                return text.Substring(0, 50) + "...";
            }*/
            return  text;
        }

        public static MvcHtmlString FormatDateTime(this DateTime value)
        {
            return new MvcHtmlString(value.ToString("d MMMM yyyy", CultureInfo.CreateSpecificCulture("ru-RU")));
        }

        /// <summary>
        /// Gets the first paragraph.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string GetFirstParagraph(this string value)
        {
            Match m = Regex.Match(value, @"<p.+?>\s*(.+?)\s*</p>");
            if (m.Success)
            {
                return m.Groups[1].Value;
            }
            return value;
        }

        public static IEnumerable<string> GetAllParagraphs(this string html)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            return doc.DocumentNode.ChildNodes.Where(item => item.Name == "p").Select(x=>x.InnerHtml);

        }

        /// <summary>
        /// Strips the HTML.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string StripHTML(this string value)
        {
            return Regex.Replace(value, @"<(.|\n)*?>", string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline);
        }

        public static MvcHtmlString ToMvcHtmlString(this string text)
        {
            return MvcHtmlString.Create(text);
        }

        public static string GetEmbedYoutubeUrl(this string url)
        {
            Match m = Regex.Match(url, @"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)");
            if (m.Success)
            {
                string id = m.Groups[1].Value;
                return string.Format("//www.youtube.com/embed/{0}", id);
            }
            return string.Empty;
        }
    }
}
