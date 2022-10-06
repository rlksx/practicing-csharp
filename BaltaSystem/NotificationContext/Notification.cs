namespace BaltaSystem.NotificationContext
{
    public sealed class Notification
    // impedindo variações dessa classe, sem heraça!
    {
        public string Property { get; set; }
        public string Message { get; set; }

        public Notification()
        {

        }

        public Notification(string property, string message)
        {
            this.Property = property;
            this.Message = message;
        }
    }
}