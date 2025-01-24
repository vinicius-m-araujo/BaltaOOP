using BaltaOOP.ContentContext.Enums;
using BaltaOOP.SharedContext;

namespace BaltaOOP.ContentContext;

public class Lecture : BaseContent
{
    public int Ordem { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
}
