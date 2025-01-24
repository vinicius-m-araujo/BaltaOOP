using BaltaOOP.SharedContext;

namespace BaltaOOP.ContentContext;

public abstract class Content : BaseContent
{
    public string Url { get; set; }
    public string Title { get; set; }

    public Content(string title, string url)
    {
        Title = title;
        Url = url;
    }
}