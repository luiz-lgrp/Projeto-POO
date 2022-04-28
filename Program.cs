using POO.ContentContext;
using POO.NotificationContext;
using POO.SubscriptionContext;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {

            var articles = new List<Article>();
            articles.Add(new Article("Tudo Sobre POO",
                "saiba-sobre-POO"));
             
            foreach (var article in articles)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"ID:{article.Id}");
                Console.WriteLine($"Título:{article.Title}");
                Console.WriteLine($"Url:{article.Url}");
                Console.WriteLine(" ");
                
            }
	        
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
	        
            var courses = new List<Course>();

            var courseOop = new Course("Fundamentos OOP", "fundamentos-Oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-CSharp");
            var courseDotnet = new Course("Fundamentos .Net", "fundamentos-DotNet");

            courses.Add(courseOop);
            courses.Add(courseCsharp);
            courses.Add(courseDotnet);
            
            
            var careers = new List<Career>();
            var careerDotnet = new Career ("Especialista .NET", "especialista-dotnet");

            var careerItem2 = new CareerItem(2,"Aprenda POO","", courseOop);
            var careerItem1 = new CareerItem(1,"Comece por aqui","", courseCsharp);
            var careerItem3= new CareerItem(3,"Aprenda .NET","", courseDotnet);

            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem1);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(" ");
                Console.WriteLine(career.Title);
                Console.WriteLine(" ");

                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    
                    Console.WriteLine($"Título: {item.Course?.Title} - Nivel: {item.Course?.Level}");
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.CreateSubscription(payPalSubscription);
            }
	

        }
    }
}