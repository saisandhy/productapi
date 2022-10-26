using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Product_Entity
{
   public  class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }

        public string ProductCode { get; set; }

        public int ProductYear { get; set; }

        public int ChannelId { get; set; }

        //public Guid SizeScaleId { get; set; }

        //public List<Articles> Articles { get; set; }
        public List<Articlesize> Articlesize { get; set; }
    }
}
