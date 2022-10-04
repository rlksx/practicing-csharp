using System;
namespace BaltaSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            var course = new ContentContext.Course();
            course.Level = ContentContext.Enums.EContentLevel.Beginner;
            foreach (var item in course.Modules)
            {
                
            }
        }
    }
}