using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FizzBuzz;

internal class Program
{
    public static void Main(string[] args)
    {
        new FizzBuzzFactory().GetFlow().Run();

        //Host.CreateDefaultBuilder()
        //    .ConfigureServices(services => services.AddSingleton<Execuo>())
        //    .
    }

    //public static void Main2(string[] args)
    //{
    //    IGenerator generator = new FizzBuzzGenerator(new FizzBuzzInputValidator(), new FizzBuzzOutputBuilder(new FizzBuzzInputMapper()));

    //    while (true)
    //    {
    //        Console.Write("Enter a number: ");
    //        string? input = Console.ReadLine();

    //        if (int.TryParse(input, out int result))
    //        {   
    //            try
    //            {
    //                Console.WriteLine(generator.Generate(result));

    //            }
    //            catch(ArgumentException ex)
    //            {
    //                Console.WriteLine(ex.Message);
    //            }
    //            Console.Write("\n");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid input");
    //            Console.Write("\n");
    //        }
    //    }
    //}
}