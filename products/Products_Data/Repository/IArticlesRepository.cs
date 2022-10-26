using Product_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Data.Repository
{
    public  interface IArticlesRepository
    {
        void AddArticles(Articles articles );
         Articles GetArticles( Guid Id );
    }
}
