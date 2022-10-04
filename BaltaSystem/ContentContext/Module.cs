namespace BaltaSystem.ContentContext
{
    public class Module // modulos da aula
    {
        public int Order { get; set; } // Ordem do mosulo
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
        public Module()
        {
            Lectures  = new List<Lecture>();
        }
    }
}