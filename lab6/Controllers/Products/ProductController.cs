using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class ProductController : Controller 
{
    private ProductsStorage _storage;
    public ProductController(ProductsStorage storage) 
    {
        _storage = storage;
    }

    [Route("/[controller]/Details/{id}")]
    [HttpGet]
    public IActionResult Index(int id)
    {
        return View(_storage.FindProduct(id));
    }

    [Route("/[controller]/Add")]
    [HttpPost]
    public IActionResult AddProduct(Product product)
    {
        _storage.Add(product);
        return RedirectToAction("Index", "Products");
    } 

    [Route("/[controller]/Remove/{id}")]
    [HttpGet]
    public IActionResult RemoveProduct(int id)
    {
        _storage.Remove(id);
        return RedirectToAction("Index", "Products");
    }

    

}