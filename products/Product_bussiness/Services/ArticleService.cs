using Product_Entity;
using Products_Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_bussiness.Services
{
  public class ArticleService
    {
        IArticlesRepository _articlesRepository;
        public ArticleService(IArticlesRepository articlesRepository)
        {
            _articlesRepository = articlesRepository;
        }
        //ADD ARTICLE

        public void AddArticles(Articles articles)
        {
            _articlesRepository.AddArticles(articles);
        }
        //GET
        public Articles GetArticles(Guid Id)
        {
            return _articlesRepository.GetArticles(Id);
        }
    }
}
