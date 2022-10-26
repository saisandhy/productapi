using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Product_Entity
{
public  class ColorP
    {
        [Key]
        public Guid ColorId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
       
    }
}
