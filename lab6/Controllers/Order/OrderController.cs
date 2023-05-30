using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class OrderController : Controller 
{
    private OrdersRepository _repository;
    public OrderController(OrdersRepository repository) 
    {
        _repository = repository;
    }

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
        _repository.CreateOrder(order);

        return Ok($"order {order.Id} created for {order.FullName} {order.PhoneNumber} {order.Comment}");
    }
}
