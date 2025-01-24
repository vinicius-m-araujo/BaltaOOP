using BaltaOOP.NotificationContext;
using BaltaOOP.SharedContext;

namespace BaltaOOP.SubscriptionContext;

public class Student : BaseContent
{
    public User User { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public IList<Subscription> Subscriptions { get; set; }
    public bool Ispremium => Subscriptions.Any(x => !x.IsInactive);

    public Student()
    {
        Subscriptions = new List<Subscription>();
    }

    public void CreateSubscription(Subscription subscription)
    {
        if (Ispremium)
        {
            AddNotification(new Notification("Premium", "This student is premium."));
            return;
        }
        Subscriptions.Add(subscription);
    }
}