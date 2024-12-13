using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace CleanBlog.Core.Extensions
{
    public static class HTMLHelperExtensions
    {
        public static IHtmlString GetGridHtml(this HtmlHelper htmlHelper, IPublishedContent contentItem, string framewrok, string propertyAlias, bool fluidImages)
        {
            if (fluidImages)
            {
                return htmlHelper.Raw(htmlHelper.GetGridHtml(contentItem, framewrok, propertyAlias).ToString().Replace("<img", "<img class=\"img-fluid\" "));
            }
            else
            {
                return htmlHelper.GetGridHtml(contentItem, framewrok, propertyAlias);
            }
        }
    }
}
