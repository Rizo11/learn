namespace ozon;

public class sale
{
    public static void Main2(string[] args)
    {
        int t = 0;
        t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            int n = 0;
            n = int.Parse(Console.ReadLine());
            int[] p = new int[n];
            p = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Dictionary<int, int> distincts = new();


            foreach (var item in p)
            {
                if(!distincts.ContainsKey(item))
                {
                    distincts.Add(item, 1);
                }
                else
                {
                    distincts[item]++;
                }
            }

            int sum = 0;
            
            foreach (var item in distincts)
            {
                sum += ((item.Value%3) * item.Key) + ((int)(item.Value/3) * item.Key * 2);
            }

            System.Console.WriteLine(sum);
        }
    }
}