namespace cr792;

class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        for (var i = 0; i < t; i++)
        {
            string number = Console.ReadLine()??"0";
            if(number.Length == 2)
            {
                System.Console.WriteLine(number[1]);
                continue;
            }
            int min = int.Parse(number[0].ToString());
        
            foreach (var letter in number)
            {
                if(min > int.Parse(letter.ToString()))
                {
                    min = int.Parse(letter.ToString());
                }
            }
            System.Console.WriteLine(min);
        }
    }
}
