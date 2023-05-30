using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class ProductsController : Controller 
{
    private ProductsStorage _storage;
    public ProductsController(ProductsStorage storage)
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

    public IActionResult AddToCart(int id, string productName, double price)
    {
        Cart.Instance.AddProduct(id, productName, price);
        return RedirectToAction("Index", "Cart");
    }
}