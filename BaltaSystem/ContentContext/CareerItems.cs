using BaltaSystem.NotificationContext;
using BaltaSystem.ShareContext;
using System.Collections.Generic;

namespace BaltaSystem.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            this.Order = order;
            this.Title = title;
            this.Description = description;
            this.Course = course;

            if (course == null)
                AddNotification( new Notification("Course", "Courso inválido") );
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}