using BaltaOOP.NotificationContext;

namespace BaltaOOP.SharedContext;

public abstract class BaseContent : Notifiable
{
    public Guid Id { get; set; }

    protected BaseContent()
    {
        Id = Guid.NewGuid();
    }
}