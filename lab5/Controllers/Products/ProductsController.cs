using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class ProductsController : Controller 
{
    [HttpGet]
    public IActionResult Index()
    {
        var products = ProductsStorage.Instance.Products; 
        return View(products);
    }

    [Route("/[controller]/New")]
    [HttpGet]
    public IActionResult AddProduct()
    {
        return View();
    }
}