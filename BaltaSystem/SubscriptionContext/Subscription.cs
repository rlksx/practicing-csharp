using BaltaSystem.ShareContext;

namespace BaltaSystem.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; } 
        // verificando se há assinatura ativa ou não

        public bool IsInactive => EndDate <= DateTime.Now;
    }
} 