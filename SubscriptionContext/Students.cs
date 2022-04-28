using System.Collections.Generic;
using POO.NotificationContext;
using POO.SharedContext;

namespace POO.SubscriptionContext
{
    public class Student : Base
    {

        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        
        public String Email { get; set; }

        public User  User { get; set; } 

        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription){
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "Já possui uma assinatura ativa"));
                return;
            }
            else
            {
                Subscriptions.Add(subscription);
            }
            
        }
        public bool IsPremium => Subscriptions.Any(x=>!x.IsInactive);
    }
}