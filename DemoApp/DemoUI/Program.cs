using DemoLibrary;

public static class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //Console.WriteLine("What is your name: ");
        //string? firstName = Console.ReadLine();

        //Console.WriteLine("What is your second name: ");
        //string? lastName = Console.ReadLine();

        //string fullName = PersonProcessor.JoinName(firstName, lastName);

        //Console.WriteLine($"Your full name is {fullName}");


        Console.WriteLine(addTwoNums(1, 2));
    }

    public static int addTwoNums(int a, int b)
    {
        return a + b;
    }
}
