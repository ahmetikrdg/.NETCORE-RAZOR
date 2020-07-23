using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace shopapp.webui
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {//serisleri proje içine dahil ederiz
            services.AddControllersWithViews();//mvc yapısını kullandım controlleri kullanacağım dedim
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //localhost:5000
            //localhost:5000/products
            //localhost:5000/products/5

            app.UseEndpoints(endpoints =>//uygulamanın ana dizinine sahip istek geldiğinde bir response string ifade göndermek
            {
                endpoints.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Home}/{action=Index}/{id?}"
                //controller=home dedim yani sen birşey çağırmasan bile ilk olarak home çıkar karşına actionu ise ındex
                );


                /* endpoints.MapGet("/", async context =>
                 {
                     await context.Response.WriteAsync("Hello World!");
                     talep gelir burası çalışır çalışınca context üzerinden response oluşturulur  ve responsada writeays metodu aracılığıyla yazı yazdırılır.n
                     yani uygulmaya gelen localhost 5001e gelen bir talep sonucu response hello word yazdırırız.
                 }); */
            });
        }
    }
}
