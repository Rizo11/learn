namespace RandomNumber;

public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Welcome:\n");
        string user = Console.ReadLine();
        var randomizer = new RandomNumber();
        while (user != "exit")
        {
            if(!string.IsNullOrEmpty(user))
                if(user.All(x => char.IsDigit(x)) == true)
                {
                    System.Console.WriteLine(randomizer.GetRandomNumber(int.Parse(user)));
                }
            user = Console.ReadLine();
        }
    }

    public interface IRandomizable
    {
        public int GetRandomNumber(int upperBound);
    }

    class RandomNumber : IRandomizable
    {
        public int GetRandomNumber(int upperBound)
        {
            var rnd = new Random();
            return rnd.Next(upperBound);
        }
    }
}