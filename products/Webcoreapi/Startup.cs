using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Product_bussiness.Services;
using Products_Data;
using Products_Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webcoreapi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionStr= Configuration.GetConnectionString("sqlconnection");
            services.AddDbContext<DbcontextProducts>(options => options.UseSqlServer(connectionStr));

            services.AddSwaggerGen();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "product API",
                    Description = "product Management System API",
                });
            });
            services.AddTransient<ProductService, ProductService>();
            services.AddTransient<IProductsRepository, ProductRepository>();
            services.AddTransient<Colorservice, Colorservice>();
            services.AddTransient<IColorPRepository, ColorRepository>();
            services.AddControllers();
            services.AddTransient<Sizeservice, Sizeservice>();
            services.AddTransient<ISizeRepository, SizeRepository>();
            services.AddTransient<ArticleService, ArticleService>();
            services.AddTransient<IArticlesRepository, ArticleRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(options => options.SwaggerEndpoint("/Swagger/v1/swagger.json", "Product API"));

            app.UseRouting();
            app.UseHttpsRedirection();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
