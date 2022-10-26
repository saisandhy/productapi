using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Product_Entity
{
   public class PSize
    {
        [Key]
        public Guid SizeId { get; set; }

        public string Name { get; set; }
    }
}
