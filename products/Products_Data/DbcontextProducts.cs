using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Product_Entity;

namespace Products_Data
{
    public class DbcontextProducts: DbContext
    {
        public DbcontextProducts(DbContextOptions<DbcontextProducts> options) : base(options)
        {

        }
        public DbSet<Products> products { get; set; }

        public DbSet<Articles> articles { get; set; }

        public DbSet<ColorP> colors{ get; set; }
        public DbSet<PSize> sizes{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2175;Initial Catalog=productitems;Integrated Security=True;");
        }


    }
}
