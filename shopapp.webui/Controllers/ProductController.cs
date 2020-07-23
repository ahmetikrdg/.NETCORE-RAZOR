using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var product = new Product { Name = "Iphone X", Price = 6000, Description = "İyi Telefon" };
           
            ViewBag.Category = "Telefonlar";

            return View(product);//model
        }
        public IActionResult list()
        {
            var product = new List<Product>(){
           new Product{Name="Iphone 8", Price=3000,Description="İyi telefon",IsApproved=true},
           new Product{Name="Iphone X", Price=6000,Description="Güzel telefon",IsApproved=true},
           new Product{Name="Iphone 9", Price=6000,Description="Güzel telefon",IsApproved=false},
           new Product{Name="Iphone 10", Price=6000,Description="Güzel telefon"}
           };


            var category = new Category { Name = "Telefon", Description = "Telefon kateogrisi" };
            //paketleyip göndereceğim
            var productsViewModel = new ProductViewModel//her ikisinide kullanmak için progda viewmodels klasörü açtım içine category ve list ekledim
            {
                Category = category, //burada oluşturduğum category ve productu productview modele gönderdim
                Products = product
            };

            return View(productsViewModel);//burdanda viewe gönderdim ve şimdi productsviewmodeli @model ..... olarak başa yazacağım
        }
        public IActionResult Details(int id)
        {

            var p = new Product();
            p.Name = "Samsung";
            p.Price = 3000;
            p.Description = "İyi telefon";

            return View(p);
        }


    }
}