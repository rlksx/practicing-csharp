using BaltaSystem.ShareContext;

namespace BaltaSystem.SubscriptionContext
{
    public class Student : Base
    {
        public User User { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }   
    }
}