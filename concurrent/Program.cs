using System.Diagnostics;
namespace concurrent
{
    class Programm
    {
        static int Total = 0;
        static object _lock = new object();
        public static void Main(string[] args)
        {
            Stopwatch timer = new();
            //single threaded
    
            // AddOneMillion();
            // AddOneMillion();
            // AddOneMillion();
            // System.Console.WriteLine("Total: {0}, time: {1}", Total, timer.ElapsedTicks);
        
            
            //multi threaded
            Thread thread1 = new Thread(AddOneMillionThreadSafe);
            Thread thread2 = new Thread(AddOneMillionThreadSafe);
            Thread thread3 = new Thread(AddOneMillionThreadSafe);

            timer.Start();
            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
            timer.Stop();
            //using Total++ in a multhithreaded program is not safe, it miscalulates. It is not atomic.
            System.Console.WriteLine("Total: {0}, time: {1}", Total, timer.ElapsedTicks);

        }

        public static void AddOneMillion()
        {
            for (var i = 0; i < 1000000; i++)
            {
                Total++;
            }
        }

        public static void AddOneMillionThreadSafe()
        {
            for (var i = 0; i < 1000000; i++)
            {
                Interlocked.Increment(ref Total);
            }
        }
         
    }
}