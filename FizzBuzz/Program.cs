using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FizzBuzz;

internal class Program
{
    public static void Main(string[] args)
    {
        Host.CreateDefaultBuilder()
            .ConfigureServices(services => services.AddSingleton<Executor>())
            .ConfigureServices(Registrations.RegisterServices)
            .Build()
            .Services.GetService<Executor>()
            .Execute();
    }
}