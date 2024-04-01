using Microsoft.AspNetCore.Mvc;
using lab8.Models;
using System.Collections.Generic;

namespace lab8.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Laptop", Price = 1200M, CreatedDate = DateTime.Now },
                new Product { ID = 2, Name = "Smartphone", Price = 800M, CreatedDate = DateTime.Now.AddDays(-1) },
                new Product { ID = 3, Name = "Tablet", Price = 600M, CreatedDate = DateTime.Now.AddDays(-2) },
            };

            return View(products);
        }
    }
}