using System;
namespace BaltaSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            // articles
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

            // courses
            var courseCsharp = new ContentContext.Course("Fundamentos C#", "fundamentos-csharp");
            var courseOOP = new ContentContext.Course("Fundamentos OOP", "fundamentos-oop");
            var courseDotnet = new ContentContext.Course("Fundamentos .NET", "fundamentos-dotnet");

            var courses = new List<ContentContext.Course>();
            courses.Add(courseCsharp);
            courses.Add(courseOOP);
            courses.Add(courseDotnet);

            // careers
            var careerDotnet = new ContentContext.Career("Especialista .NET", "especialista-dotnet");
            var careerItem02 = new ContentContext.CareerItem(2, "Começando com C#", "", courseOOP);
            var careerItem01 = new ContentContext.CareerItem(1, "Introdução da Carreira", "", courseCsharp);
            var careerItem03 = new ContentContext.CareerItem(3, "Introdução da OOP", "", courseDotnet);
            careerDotnet.Items.Add(careerItem02);
            careerDotnet.Items.Add(careerItem01);
            careerDotnet.Items.Add(careerItem03);

            var careers = new List<ContentContext.Career>();
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);
                }
            }

        }
    }
}