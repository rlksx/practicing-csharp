using System;
namespace BaltaSystem.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }

        public Course()
        {
            Modules = new List<Module>();
        }
    }
}