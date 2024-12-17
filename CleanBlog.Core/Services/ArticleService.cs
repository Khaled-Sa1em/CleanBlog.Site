using CleanBlog.Core.Helpers;
using CleanBlog.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace CleanBlog.Core.Services
{
    public class ArticleService : IArticleService
    {
        public IPublishedContent GetArticleListPage(IPublishedContent siteRoot)
        {
            return siteRoot.Descendants().Where(d => d.ContentType.Alias == "articleList").FirstOrDefault();
        }

        public IEnumerable<IPublishedContent> GetLatestArticles(IPublishedContent model)
        {
            var siteRoot = model.Root();
            var articleList = GetArticleListPage(siteRoot);
            return articleList.Descendants()
                .Where(d => d.IsVisible() && d.ContentType.Alias == "article")
                .OrderByDescending(d => d.Value<DateTime>("publishDate"));
        }

        public ArticleResultSet GetLatestArticles(IPublishedContent model, HttpRequestBase request)
        {
            var siteRoot = model.Root();
            var articleList = GetArticleListPage(siteRoot);
            var articles = articleList.Descendants()
                .Where(a => a.IsVisible() && a.ContentType.Alias == "article")
                .OrderByDescending(d => d.Value<DateTime>("publishDate")); ;
            var pageNumber = QueryStringHelpers.GetIntFromQueryString(request, "page", 1);
            var pageSize = QueryStringHelpers.GetIntFromQueryString(request, "size", 10);
            var isArticlePageList = articleList.Id == model.Id;
            var result = isArticlePageList ? articles.Skip((pageNumber - 1) * pageSize).Take(pageSize) : articles.Take(3);
            var totalCount = articles.Count();
            var pageCount = totalCount > 0 ? Math.Ceiling((double)totalCount / pageSize) : 1;

            return new ArticleResultSet()
            {
                IsArticleListPage = isArticlePageList,
                PageCount = pageCount,
                PageNumber = pageNumber,
                PageSize = pageSize,
                Url = articleList.Url(),
                Results = result
            };
        }
    }
}
