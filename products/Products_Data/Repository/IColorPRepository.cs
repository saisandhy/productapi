using Product_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Data.Repository
{
   public interface IColorPRepository
    {
        void AddColor(ColorP color );
        ColorP GetColor( Guid Id );
    }
}
