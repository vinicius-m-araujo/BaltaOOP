namespace BaltaOOP.NotificationContext;

public sealed class Notification
{
    public string Propety { get; set; }
    public string Message { get; set; }

    public Notification()
    {
    }

    public Notification(string propety, string message)
    {
        Propety = propety;
        Message = message;
    }
}