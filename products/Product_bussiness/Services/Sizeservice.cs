using Product_Entity;
using Products_Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_bussiness.Services
{
    public  class Sizeservice

    {
        ISizeRepository _sizeRepository;

        public Sizeservice(ISizeRepository sizeRepository)
        {
            _sizeRepository = sizeRepository;
        }
        public void AddSize(PSize pSize)
        {
            _sizeRepository.AddSize(pSize);
        }
         public PSize GetSize(Guid Id)
        {
            return _sizeRepository.GetSize(Id);
        }
    }
}
