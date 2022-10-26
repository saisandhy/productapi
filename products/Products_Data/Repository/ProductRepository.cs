using Product_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Data.Repository
{
    public class ProductRepository : IProductsRepository
    {
        DbcontextProducts _productdbContext;

        public ProductRepository(DbcontextProducts productdbContext)
        {
            _productdbContext = productdbContext;
        }

        public void AddProductsI(Products products)
        {
            Guid pid = Guid.NewGuid();
            products.ProductId = pid;
            _productdbContext.products.Add(products);
            _productdbContext.SaveChanges();
        }

        
        public Products GetProducts(Guid Id)
        {
            return _productdbContext.products.Find(Id);
        }
    }
}
