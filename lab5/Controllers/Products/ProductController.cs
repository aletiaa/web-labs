using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class ProductController : Controller 
{
    [Route("/[controller]/Details/{id}")]
    [HttpGet]
    public IActionResult Index(int id)
    {
        return View(ProductsStorage.Instance.FindProduct(id));
    }

    [Route("/[controller]/Add")]
    [HttpPost]
    public IActionResult AddProduct(Product product)
    {
        ProductsStorage.Instance.Add(product);
        return RedirectToAction("Index", "Products");
    } 

    [Route("/[controller]/Remove/{id}")]
    [HttpGet]
    public IActionResult RemoveProduct(int id)
    {
        ProductsStorage.Instance.Remove(id);
        return RedirectToAction("Index", "Products");
    }

    

}