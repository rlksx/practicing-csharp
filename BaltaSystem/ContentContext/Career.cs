using System;
namespace BaltaSystem.ContentContext
{
    public class Career : Content
    {
        public int Courses { get; set; }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;
        // Expression Body, get;

        public Career(string title, string url)
            : base(title, url)
        {
            Items = new List<CareerItem>();
        }
    }
}  