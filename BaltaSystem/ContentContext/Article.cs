using System;
namespace BaltaSystem.ContentContext
{
    class Article : Content
    {
        public IList<NotificationContext.Notification> Notifications { get; set; }
        public Article(string title, string url)
            : base(title, url)
        {

        }
    }
}