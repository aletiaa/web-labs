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
        List<Order> allOrders = _repository.GetAllOrders();
        return View(allOrders);
    }

    public IActionResult NewOrder()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateOrder(Order order)
    {
        _repository.CreateOrder(order);

        return View("Order", order);
    }
}
