using FlipLoginAndRegister.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlipLoginAndRegister.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var Products = new List<ProdList>
            {
  new ProdList{Id=1,Name="Fridges",imagelink="ListOfProducts/Fridge.jpg"},
   new ProdList{Id=1,Name="Washing Machines",imagelink="ListOfProducts/HaierWM.jpg"},
    new ProdList{Id=1,Name="Laptops",imagelink="ListOfProducts/HP.jpg"},
     new ProdList{Id=1,Name="AC",imagelink="ListOfProducts/LloydAC.jpg"},
      new ProdList{Id=1,Name="Mobiles",imagelink="ListOfProducts/SamsungMobile.jpg"},
       new ProdList{Id=1,Name="TVs",imagelink="ListOfProducts/SonyTV.jpg"}
            };

            return View(Products);
        }
    }
}
