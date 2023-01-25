using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FizzBuzz;

public static class Registrations
{
    public static void RegisterServices(HostBuilderContext hostContext, IServiceCollection services)
    {
        services.AddScoped<IFactory, FizzBuzzFactory>();
        services.AddScoped<IFlow, FizzBuzzFlow>();
        services.AddScoped<IConsole, FizzBuzzConsole>();
        services.AddScoped<IGenerator, FizzBuzzGenerator>();
        services.AddScoped<IInputMapper, FizzBuzzInputMapper>();
        services.AddScoped<IInputValidator, FizzBuzzInputValidator>();
        services.AddScoped<IOutputBuilder, FizzBuzzOutputBuilder>();
    }
}
