
namespace Test.Models;

public abstract class QnA
{
    public int Type { get; set; }
    public string Question { get; set; }
    public string RealAnswer { get; set; }
    public List<string> Answer { get; set; }
}

public class Question1 : QnA
{
    public Question1()
    {
        Type = 1;
    }
}
public class Question
{
    public int Q_type { get; set; }
    public string Q { get; set; } 
    public string A { get; set; }

    public Question(string q, string a, int q_type = 0)
    {
        Q = q;
        A = a;
        Q_type = q_type;
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