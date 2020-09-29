using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic_Crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic_Crud.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var products = _repo.GetAllProducts();
            return View(products);
        }

        public IActionResult ViewProduct(int id)
        {
            var product = _repo.GetProduct(id);
            return View(product);
        }
    }
}
