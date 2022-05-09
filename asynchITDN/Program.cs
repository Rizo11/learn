using System.Runtime.CompilerServices;

namespace asynchITDN
{
    class Program
    {
        static void Main(string[] args)
        {
            //use this with MyClass1
            // System.Console.WriteLine("Main ThreadID = {0}\n", Thread.CurrentThread.ManagedThreadId);
            // MyClass1 my = new();
            // my.OperationAsync();
            // Console.ReadKey();
        
            // use this with MyClass2
            MyClass2 my = new();
            my.OperationAsync();

            System.Console.WriteLine("Main ThreadID ended it's job = {0}\n", Thread.CurrentThread.ManagedThreadId);
            
            Console.ReadKey();
        }
    } 

    class MyClass2
    {
        int Operation()
        {
            Console.WriteLine("Operation is executed in ThreadId: {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            return 2 + 2;
        }


        // async refers that a method is asynchronous 
        public async void OperationAsync()
        {
            // without async
            // Task<int> task = Task<int>.Factory.StartNew(Operation);
            // TaskAwaiter<int> awaiter = task.GetAwaiter();
            // Action continuation = () => System.Console.WriteLine("\nResult: {0}\n", awaiter.GetResult());
            // awaiter.OnCompleted(continuation);


            // with async
            // await is for waiting for the task to complete, waiting for async task to complete

            // Main Thread
            Task<int> task = Task<int>.Factory.StartNew(Operation);

            // Another thread
            System.Console.WriteLine("\nResult: {0}\n", await task);
        }
    }
    class MyClass1
    {
        public void Operation()
        {
            Console.WriteLine("Operation ThreadId: {0}", Thread.CurrentThread.ManagedThreadId);
            System.Console.WriteLine("Begin");
            Thread.Sleep(2000);
            System.Console.WriteLine("End\n");
        }

        public async void OperationAsync()
        {
            // Thread's id is same as the main thread's id
            // this methods starts on the same thread as the main thread
            Console.WriteLine("OperationAsync ( Part 1 ) ThreadId: {0}\n", Thread.CurrentThread.ManagedThreadId);
            
            Task task = new Task(Operation);
            task.Start();
            await task;

            // Thread's id is same as the 2nd thread's id
            // this methods ends on the same thread as the 2nd thread
            Console.WriteLine("OperationAsync ( Part 2 ) ThreadId: {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}