using Benday.ConfigOptionsDemo.WebUi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Benday.ConfigOptionsDemo.WebUi.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _Logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _Logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
