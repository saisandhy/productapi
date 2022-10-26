using Product_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Data.Repository
{
    public class ColorRepository : IColorPRepository
    {
        DbcontextProducts _colordbContext;
        public ColorRepository(DbcontextProducts colordbContext)
        {
            _colordbContext = colordbContext;
        }

        public void AddColor(ColorP color)
        {
            Guid cid = Guid.NewGuid();
            color.ColorId = cid;
            _colordbContext.colors.Add(color);
            _colordbContext.SaveChanges();
        }

        public ColorP GetColor(Guid Id)
        {
            return _colordbContext.colors.Find(Id);
        }
    }
}
