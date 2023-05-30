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
}