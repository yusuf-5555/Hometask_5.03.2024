public abstract class AbstractBook : IReadable
{
    string _title;
    string _author;

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }

   public void Read()
    {
       System.Console.WriteLine("The book is being read.");;
    }
}