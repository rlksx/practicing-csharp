using System;
namespace BaltaSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            var articles = new List<ContentContext.Article>();
            articles.Add( new ContentContext.Article("Artigo sobre OOP", "orientacao-objetos") );
            articles.Add( new ContentContext.Article("Artigo sobre MAUI", "maui-article") );
            articles.Add( new ContentContext.Article("Artigo sobre .NET 6", "dotnet6-news") );

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
        }
    }
}