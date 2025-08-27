// See https://aka.ms/new-console-template for more information
using MyFirstGitHubClassRoomConsoleApp60;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        demo d = new demo(5, "Hello, World!");
        for (int i = 0; i < d.LineAmount; i++) Console.WriteLine(d.LineContent);
    }
}