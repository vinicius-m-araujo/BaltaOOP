using BaltaOOP.SharedContext;

namespace BaltaOOP.ContentContext;
using System.Collections.Generic;
public class Module : BaseContent
{
    public int Order { get; set; }
    public string Title { get; set; }
    public IList<Lecture> Lectures { get; set; }

    public Module()
    {
        Lectures = new List<Lecture>();
    }
}
