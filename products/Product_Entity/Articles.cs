using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Product_Entity
{
public  class Articles
    {
        [Key]
        public Guid ArticleId { get; set; }

        public string ArticleName { get; set; }

        [ForeignKey("Products")]
        public Guid ProductId { get; set; }
        public Products Products { get; set; }

        [ForeignKey("ColorP")]
        public Guid ColorId { get; set; }

        public ColorP ColorP { get; set; }
    }
}
