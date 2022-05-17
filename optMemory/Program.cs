using System.Numerics;
using System.Diagnostics;

namespace optMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array6 = new int[10, 10];

            fill(array6, 10);

            var timer = new Stopwatch();
            timer.Start();
            for (var j = 0; j < 1_000_000_000; j++)
            {
                timer = timer;
            }
            timer.Stop();
            System.Console.WriteLine($"Time taken: {timer.ElapsedTicks}");
            timer.Reset();
            timer.Start();
            int i = 0;
            for(; i < 1_000_000_000; i++)
            {
                timer = timer;
            }
            timer.Stop();
            System.Console.WriteLine($"Time taken: {timer.ElapsedTicks}");
            timer.Reset();





        }
        static int matrixsum1(int size, int[,] M)
        {
            int sum = 0;

            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    sum += M[i,j];   // обходим построчно
                    System.Console.Write(M[i,j] + " ");
                }
            System.Console.WriteLine("\n");
            }
            return sum;
        }

        static int matrixsum2(int size, int[,] M)
        {
            int sum = 0;

            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    sum += M[j,i];    // обходим по столбцам
                    System.Console.Write(M[j,i] + " ");
                }
                System.Console.WriteLine("\n");
            }
            return sum;
        }

        static void fill(int[,] M, int size)
        {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    M[i,j] = j;
                }
            }
        }
    }

    
}