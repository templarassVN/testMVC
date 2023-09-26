namespace Test.Models;

public class Content
{
    public string Name { get; set; }
    public string[] Questions { get; set; }

    public Content()
    {
        Name = "ASP.Net la gi?";
        Questions = new string[] { "Razor View", "Model", "Controller" };
    }

    public Content(string name, string[] questions)
    {
        Name = name;
        Questions = questions;
    }
};