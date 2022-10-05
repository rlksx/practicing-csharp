namespace BaltaSystem.ContentContext
{
    public class CareerItem
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            this.Order = order;
            this.Title = title;
            this.Description = description;
            this.Course = course;

            if (course == null)
                throw new SystemException("O curso não pode ser nulo!");
                // gerando exeção!
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}