
namespace Test.Models;
public class Question
{
    public string Q { get; set; } 
    public string A { get; set; }

    public Question(string q, string a)
    {
        Q = q;
        A = a;
    }
}

public class CategoryContent
{
    
    public char Type { get; set; } 
    public List<Question> Questions { get; set; }

    public CategoryContent()
    {
        Questions = new List<Question>();
    }

    public CategoryContent(char type, List<Question> questions)
    {
        Type = type;
        Questions = questions;
    }

    void AddQuestion(Question q)
    {
        Questions.Add(q);
    }
}