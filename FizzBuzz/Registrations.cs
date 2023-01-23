using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FizzBuzz;

public static class Registrations
{
    public static void RegisterServices(HostBuilderContext hostContext, IServiceCollection services)
    {
        services.AddTransient<IFactory, FizzBuzzFactory>();
        services.AddTransient<IFlow, FizzBuzzFlow>();
        services.AddTransient<IConsole, FizzBuzzConsole>();
        services.AddTransient<IGenerator, FizzBuzzGenerator>();
        services.AddTransient<IInputMapper, FizzBuzzInputMapper>();
        services.AddTransient<IInputValidator, FizzBuzzInputValidator>();
        services.AddTransient<IOutputBuilder, FizzBuzzOutputBuilder>();
    }
}
