using Product_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Data.Repository
{
  public  interface IProductsRepository
    {
        void AddProductsI(Products products);
       
        Products GetProducts(Guid Id);

    }
}
