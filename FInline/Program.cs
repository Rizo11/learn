using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace FInline
{
    public class Program
    {
        const int _max = 1000000;
        public static void Main(string[] args)
        {
            Method1();
            Method2();

            var timer = new Stopwatch();
            int sum = 0;
            timer.Start();
            for (var i = 0; i < _max; i++)
            {
                sum += Method1();
            }
            timer.Stop();
            System.Console.WriteLine($"Method1: {timer.ElapsedTicks}");
            timer.Reset();
            sum = 0;
            timer.Start();
            for (var i = 0; i < _max; i++)
            {
                sum += Method2();
            }
            timer.Stop();
            System.Console.WriteLine($"Method2: {timer.ElapsedTicks}");
            timer.Reset();
        }
        static int Method1()
        {
            return 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        static int Method2()
        {
            return 1;
        }
    }

}