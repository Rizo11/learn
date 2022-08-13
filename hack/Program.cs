using System;
using System.IO;
using System.Text;

class Program
{
    public static void Main()
    {
        for (var m = 1; m < 11; m++)
        {
            string path = "0";
            var randomer = new Random();
            try
            {
                int n = randomer.Next(1, 101);
                int[] a = new int[n];
                int sum = 0, mySum = 0, myCoins = 0;
                int[] coins = new int[101];
                for(int i = 0; i < 101; i++)
                    coins[i] = 0;
                for (var i = 0; i < n; i++)
                {
                    a[i] = randomer.Next(1, 101);
                    sum += a[i];
                    coins[a[i]]++;
                }
                // Create the file, or overwrite if the file exists.
                path = @$"D:\learn\hack\tests\{m}.in";
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes($"{n}\n");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                    foreach (var i in a)
                    {
                        info = new UTF8Encoding(true).GetBytes($"{i} ");
                        fs.Write(info, 0, info.Length);
                    }
                }
                
                int n1 = 100;
                while(mySum <= sum/2 && n1 != 0)
                {
                    while(coins[n1] > 0 && (sum/2 >= mySum))
                    {
                        mySum += n1;
                        myCoins++;
                        coins[n1] -= 1;
                    }
                    n1--;
                }
                path = @$"D:\learn\hack\tests\{m}.out";
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(n.ToString()+"\n");
                    if(n == 1)
                    {
                        info = new UTF8Encoding(true).GetBytes("1");
                        fs.Write(info, 0, info.Length);
                    }
                    else
                    {
                        info = new UTF8Encoding(true).GetBytes(myCoins.ToString());
                        fs.Write(info, 0, info.Length);
                    }
                }

                
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}