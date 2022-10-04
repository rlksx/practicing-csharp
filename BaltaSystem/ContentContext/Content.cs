using System;
namespace BaltaSystem.ContentContext
{
    public abstract class Content
    // superclasse abstrata
    {
        public Guid Id { get; set; }
        // Guid => Indentificador Unico Global
        public string Title { get; set; }  
        public string Url { get; set; }

        public Content(string title, string url)
        {
            this.Title = title;
            this.Url = url;
            Id = Guid.NewGuid(); // Gerando Guid
        }
    }
} 