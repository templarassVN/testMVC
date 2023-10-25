using System.Diagnostics;
using Markdig;
using Microsoft.AspNetCore.Mvc;
using Test.filters;
using Test.Models;

namespace Test.Controllers;

public class mod
{
    public string markdown { get; set; }
    
    public string name { get; set; }
}

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
    [HttpPost]
    public IActionResult Create([FromBody] mod Md)
    {
        
        MarkdownMock.GetInstance().topic.Add(Md.markdown);
        List<string> tmp = MarkdownMock.GetInstance().topic;
        return RedirectToAction("Privacy");
    }
    [HttpGet]
    public IActionResult Privacy()
    {
        List<string> tmp = MarkdownMock.GetInstance().topic;
        var result = tmp.Select(x => Markdown.ToHtml(x));
        return View(result);
    }
    
    public IActionResult Learning()
    {
        return View();
    }

   
    
    public IActionResult Interview([FromQuery] string behavior = "")
    {
        return View();
    }
    

    // public IActionResult TestComponent([FromQuery] char data)
    // {
    //     CategoryContent c = new CategoryContent();
    //     c.Type = data;
    //     return ViewComponent("Data", new { categoryContent = c});
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
