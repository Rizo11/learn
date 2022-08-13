using System.Text.RegularExpressions;

namespace ozon;

public class Program
{
    public static void Main(string[] args)
    {
        int t = 0;
        t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            Console.ReadLine();


            int[] p = new int[2];
            p = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int [] k = new int[p[0]];
            
            for (int j = 0; j < p[1]; j++)
            {
                int[] z = new int[2];
                z = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int svobodniy = 0;
                
                if(z[0] == 1)
                {

                    //bronirovaniye
                    if(k[z[1]-1] == 0)
                    {
                        k[z[1]-1] = 1;
                        System.Console.WriteLine("SUCCESS");
                        svobodniy = z[1]+1;
                    }
                    else
                    {
                        System.Console.WriteLine("FAIL");
                    }
                }
                else if(z[0] == 2)
                {
                    if(k[z[1]-1] == 0)
                    {
                        System.Console.WriteLine("FAIL");
                    }
                    else
                    {
                        System.Console.WriteLine("SUCCESS");
                        k[z[1]-1] = 0;
                        if((z[1]-1) %2 == 1 && z[1] <= p[0] && k[z[1]] == 0)
                        {
                            svobodniy = z[1]-1;
                        }
                        else if((z[1]-1) %2 == 0 && z[1]-2 >= 0 && k[z[1]-2] == 0)
                        {
                            svobodniy = z[1]-2;
                        }
                    }
                }
                else
                {
                    for(int q = 0; q < p[0]; q++)
                    {
                        if(k[q] == 0)
                        {
                            if(q+1 < p[0] && k[q+1] == 0)
                            {
                                System.Console.WriteLine($"SUCCESS {q+1}-{q+2}");
                                break;
                            }
                        }
                    }
                }

            }
        }
    }
}