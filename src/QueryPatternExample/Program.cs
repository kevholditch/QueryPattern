using System;
using QueryPatternExample.Queries;

namespace QueryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerBuilder.Build();
            var queryExector = container.Resolve<IQueryExecutor>();

            Console.WriteLine("Enter category to search for:");
            var name = Console.ReadLine();

            var categories = queryExector.Execute<GetCategoriesMatchingNameCriteria, GetCategoriesMatchingNameResult>(new GetCategoriesMatchingNameCriteria { Name = name }).Categories;

            Console.WriteLine("categories found matching name: {0}", name);

            foreach (var category in categories)
                Console.WriteLine(category);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
