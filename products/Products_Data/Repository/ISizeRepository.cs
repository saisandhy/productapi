using Product_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Data.Repository
{
   public interface ISizeRepository
    { 
        void AddSize(PSize pSize);

        PSize GetSize(Guid Id);
   }
}
