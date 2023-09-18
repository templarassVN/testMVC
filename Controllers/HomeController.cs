using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test.filters;
using Test.Models;

namespace Test.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    [TypeFilter(typeof(TokenAuthorizationFilter))]
    public IActionResult Index()
    {
        return View();
    }

    [TypeFilter(typeof(TokenResultFilter))]
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
