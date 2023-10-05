namespace Test.Models;

public class MarkdownMock
{
    private static MarkdownMock _instance;
    public List<string> topic { get; set; }

    public static MarkdownMock GetInstance()
    {
        if (_instance == null)
        {
            _instance = new MarkdownMock();
            _instance.topic = new List<string>();
        }
        return _instance;
    }
}