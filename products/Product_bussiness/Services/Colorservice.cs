using Product_Entity;
using Products_Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_bussiness.Services
{
   public  class Colorservice
    {
        IColorPRepository _colorPRepository;
        public Colorservice(IColorPRepository colorPRepository)
        {
            _colorPRepository = colorPRepository;
        }
        public void AddColor(ColorP color)
        {
            _colorPRepository.AddColor(color);
        }
        public ColorP GetColor(Guid Id)
        {
            return _colorPRepository.GetColor(Id);
        }
    }
}
