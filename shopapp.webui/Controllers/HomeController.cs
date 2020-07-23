using System;
using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{
    public class HomeController : Controller//.netcore içinde var olan Controller clasını Homeconstroller clasına kalıttımki Homecontroller controller gibi hareket etsin
    {
        public IActionResult Index()
        {
            int saat=DateTime.Now.Hour;
            string mesaj=saat>12?"İyi Günler":"Günaydın";
            ViewBag.Greeting=mesaj;//viewbagi yazdım greeting ismini kendim verdim
            ViewBag.UserName="Ahmet";
            return View();
            //Viewe uyan yapı tanımlamamız lazım o yüzden IActionResult
        }
        public IActionResult Abouth()
        {
            return View();
        }
         public IActionResult Contact()
        {
            return View("MyView");//View("MyView") myviewi arar eğer boş bıraksaydık contactı arardı
        }
    }
}