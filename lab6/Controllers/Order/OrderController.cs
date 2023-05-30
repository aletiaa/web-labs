using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class OrderController : Controller 
{
    public OrderController() {}

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult NewOrder()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateOrder(Order order)
    {
        return Ok($"order created for {order.FullName} {order.PhoneNumber} {order.Comment}");
    }
}
