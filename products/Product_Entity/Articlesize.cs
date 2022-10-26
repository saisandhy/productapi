using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Product_Entity
{
    public class Articlesize
    {
        [Key]

        public Guid ASid { get; set; }
        [Required]
        [ForeignKey("Articles")]
        public Guid ArticleId { get; set; }
        //public Articles articles { get; set; }

        [ForeignKey("PSize")]
        public Guid SizeId { get; set; }
        //public PSize PSize { get; set; }
    }
}
