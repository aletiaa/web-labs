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
}