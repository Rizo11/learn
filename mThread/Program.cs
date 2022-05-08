namespace mThread
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            System.Console.WriteLine("Enter numbers:\n1 = button1\n2 = button2");
            int input = 0;


            //single threaded
            //this programm will run in the same thread as the main programm
            //when programm run button1(), it will take at least 5 secs. And it can't continue executing the rest of the code, bc it is single threaded.
            //it will wait for 5 seconds. AKA the programm will be paused.
            //we can use multithreading to run the programm in multiple threads. AKA in one thread,
            while ((input = int.Parse(Console.ReadLine())) != 3)
            {
                if(input == 1)
                {
                    button1(); //this function will be executed at least in 5 secs
                    
                    //we can use multithreading to run the button1 in multiple threads. AKA in one thread.
                    // Thread button1Thread = new Thread(button1);
                    // button1Thread.Start();
                }
                else
                {
                    button2(); //faster function
                }
                System.Console.WriteLine("end of loop");
            }
        }

        public static void button1()
        {
            System.Console.WriteLine("button1 started");
            Thread.Sleep(5000); // Sleep for 5 seconds
            System.Console.WriteLine("button1 ended");
            //imagine that this function is sent request for DB, to get the data, which will take about 5 seconds.
        }
        public static void button2()
        {
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}