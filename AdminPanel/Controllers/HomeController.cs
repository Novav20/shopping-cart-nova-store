using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Models;
using ShoppingCart.Business;

namespace AdminPanel.Controllers;

public class HomeController(ILogger<HomeController> logger, UserService userService) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;
    private readonly UserService _userService = userService;

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Users()
    {
        var users = _userService.GetUsers();
        return View(users);
    }
    public JsonResult GetUsers()
    {
        var users = _userService.GetUsers();
        return Json(users);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
