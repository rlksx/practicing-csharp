namespace BaltaSystem.ContentContext
{
    public abstract class Base : NotificationContext.Notifiable
    {
        public Guid Id { get; set; }

        public Base()
        {
            Id = Guid.NewGuid(); // Gerando Guid
        }
    }
} 