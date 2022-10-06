using System;
using BaltaSystem.ContentContext;
using BaltaSystem.NotificationContext;
using BaltaSystem.SubscriptionContext;

// flunt notifications

namespace BaltaSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            // articles
            var articles = new List<Article>();
            articles.Add( new Article("Artigo sobre OOP", "orientacao-objetos") );
            articles.Add( new Article("Artigo sobre MAUI", "maui-article") );
            articles.Add( new Article("Artigo sobre .NET 6", "dotnet6-news") );

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            // courses
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseDotnet = new Course("Fundamentos .NET", "fundamentos-dotnet");

            var courses = new List<Course>();
            courses.Add(courseCsharp);
            courses.Add(courseOOP);
            courses.Add(courseDotnet);



            // careers
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem02 = new CareerItem(2, "Começando com C#", "", null);
            var careerItem01 = new CareerItem(1, "Introdução da Carreira", "", courseDotnet);
            var careerItem03 = new CareerItem(3, "Introdução da OOP", "", courseOOP);
            careerDotnet.Items.Add(careerItem02);
            careerDotnet.Items.Add(careerItem01);
            careerDotnet.Items.Add(careerItem03);

            var careers = new List<Career>();
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                }
            }

            // students
            var payPalSubscription = new PayPalSubscription();
            var student =  new Student();
            student.CreateSubscription(payPalSubscription);

        }
    }
} 