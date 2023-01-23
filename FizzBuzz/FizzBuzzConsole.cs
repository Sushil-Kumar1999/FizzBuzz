namespace FizzBuzz;

public class FizzBuzzConsole : IConsole
{
    public string Read()
    {
        return Console.ReadLine() ?? "";
    }

    public void Write(string input)
    {
        Console.WriteLine(input);
    }
}
