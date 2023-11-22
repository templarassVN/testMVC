using System.Diagnostics;
using CliWrap;
using CliWrap.Buffered;
using Microsoft.AspNetCore.Mvc;
using Test.filters;
using Test.Models;

namespace Test.Controllers;
public class Submisson
{
    public string code { get; set; }
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
    
    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult Learning()
    {
        return View();
    }

    List<CategoryContent> createMock()
    {
        List<CategoryContent> contents = new List<CategoryContent>();
        CategoryContent c1 = new CategoryContent();
        c1.Type = 'A';
        c1.Questions.Add(new Question("WTF?","VCL"));
        c1.Questions.Add(new Question("WTF1?","VCL1"));
        CategoryContent c2 = new CategoryContent();
        c2.Type = 'B';
        c2.Questions.Add(new Question("q1w2?","q1w2"));
        c2.Questions.Add(new Question("q1w2e3?","q1w2e3"));
        contents.Add(c1);
        contents.Add(c2);
        return contents;
    }
    
    public IActionResult Interview([FromQuery] char type = ' ')
    {
        List<CategoryContent> total = createMock();
        List<CategoryContent> results = total;
        if(type != ' ')
            results = total.FindAll(o => o.Type == type);
        return View(results);
    }
    [HttpPost]
    public async Task<string> Code([FromBody] Submisson code)
    {
        var tmp =Directory.GetCurrentDirectory();
        var path = Path.GetFullPath( Path.Combine(tmp, @"..\code")).Replace(@"\", @"/");
        
        var cmd = Cli.Wrap("dotnet")
            .WithWorkingDirectory(path)
            .WithArguments($"run {code.code}")
            .WithValidation(CommandResultValidation.None); ;
        var result = await cmd.ExecuteBufferedAsync() ;
        return result.StandardOutput;
    }

    public IActionResult TestComponent([FromQuery] char data)
    {
        CategoryContent c = new CategoryContent();
        c.Type = data;
        return ViewComponent("Data", new { categoryContent = c});
    }

    public IActionResult Create()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
