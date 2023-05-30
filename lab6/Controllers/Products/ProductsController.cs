using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class ProductsController : Controller 
{
    private ProductsRepository _storage;
    public ProductsController(ProductsRepository storage)
    {
        _storage = storage;
    }
    [HttpGet]
    public IActionResult Index()
    {
        var products = _storage.Products; 
        return View(products);
    }

    [Route("/[controller]/New")]
    [HttpGet]
    public IActionResult AddProduct()
    {
        return View();
    }
}