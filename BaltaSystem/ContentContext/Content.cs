namespace BaltaSystem.ContentContext
{
    public abstract class Content : Base
    // superclasse abstrata
    {
        // Guid => Indentificador Unico Global
        public string Title { get; set; }  
        public string Url { get; set; }

        public Content(string title, string url)
        {
            this.Title = title;
            this.Url = url;
        }
    }
} 