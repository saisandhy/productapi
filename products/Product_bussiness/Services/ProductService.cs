using Product_Entity;
using Products_Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Product_bussiness.Services
{
    public  class ProductService
      
    {
        IProductsRepository _productsRepository;
        public ProductService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        //addproducts

        public void AddProductsI(Products products)
        {
            Random rand = new Random();
             var Count2 = 1000000000;
            switch (products.ChannelId)
            {
                case 1:
                    
                    int num;
                    num = rand.Next(0, 1000);
                    products.ProductCode = products.ProductYear.ToString() + num.ToString();
                    break;
                case 2:
                    int stringlen = rand.Next(5, 10);
                    int randValue;
                    string str = "";
                    char letter;
                    for (int i = 0; i < 6; i++)
                    {



                        randValue = rand.Next(0, 26);




                        letter = Convert.ToChar(randValue + 65);




                        str = randValue.ToString() + letter;
                    }
                    products.ProductCode = str;
                    break;
                case 3:
                    products.ProductCode = Count2.ToString();
                    Count2++;
                    break;
            }
            _productsRepository.AddProductsI(products);
        }

        public Products GetProducts( Guid Id)
        {
            return _productsRepository.GetProducts(Id);
        }
    } 
}
