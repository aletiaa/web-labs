using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class CartController : Controller 
{
    public CartController() {}

    public IActionResult Index()
    {
        return View(Cart.Instance);
    }

    public IActionResult AddToCart(int id, string productName, double price)
    {
        Cart.Instance.AddProduct(id, productName, price);
        return RedirectToAction("Index", "Cart");
    }

    public IActionResult RemoveFromCart(int id)
    {
        Cart.Instance.RemoveProduct(id);
        return RedirectToAction("Index", "Cart");
    }
}