using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Views.ViewComponents;
[ViewComponent]
public class Data : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(CategoryContent categoryContent)
    {
        return View("Test", categoryContent);
    }
}