using System;
namespace BaltaSystem.ContentContext
{
    public class Lecture // aula
    {
        public int Ordem { get; set; } // ordem das aulas
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public Enums.EContentLevel Level { get; set; }
    }
}