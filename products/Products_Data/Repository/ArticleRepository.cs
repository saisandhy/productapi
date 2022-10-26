using Product_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Data.Repository
{
    public class ArticleRepository : IArticlesRepository
    {
        DbcontextProducts _articledbContext;
        public ArticleRepository(DbcontextProducts articledbContext)
        {
            _articledbContext = articledbContext;
        }

        public void AddArticles(Articles articles)
        {
            Guid id = Guid.NewGuid();
            articles.ArticleId = id;
            _articledbContext.articles.Add(articles);
            _articledbContext.SaveChanges();

        }

        public Articles GetArticles(Guid Id)
        {
           return _articledbContext.articles.Find(Id);
        }
    }
}
