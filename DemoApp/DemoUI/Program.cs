using DemoLibrary;


Console.WriteLine("Hello, World!");

Console.WriteLine("What is your name: ");
string? firstName = Console.ReadLine();

Console.WriteLine("What is your second name: ");
string? lastName = Console.ReadLine();

string fullName = PersonProcessor.JoinName(firstName, lastName);

Console.WriteLine($"Your full name is {fullName}");