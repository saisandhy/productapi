using Product_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Data.Repository
{
    public class SizeRepository : ISizeRepository
    {
        DbcontextProducts _sizedbContext;
        public SizeRepository(DbcontextProducts sizedbContext)
        {
            _sizedbContext = sizedbContext;
        }

        public void AddSize(PSize pSize)
        {
            Guid sid = Guid.NewGuid();
            pSize.SizeId = sid;
            _sizedbContext.sizes.Add(pSize);
            _sizedbContext.SaveChanges();
        }

        public PSize GetSize(Guid Id)
        {
            return _sizedbContext.sizes.Find(Id);
        }
    }
}
