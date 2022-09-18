using ExceptionsLibrary;

namespace exHandling;

public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("exHandling");
        DemoCode demo = new();

        /*try
        {
            int result = demo.GrandParent(5);
            Console.WriteLine($"result at given position is {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }*/

        /*int result = demo.GrandParent(4);
        Console.WriteLine($"result at given position is {result}");*/
        int num = Main1();
        Console.WriteLine($"returning value {num}");
    }
    
    public static int Main1()
    {
        int returnValue = 0;
        try
        {
            returnValue += 1;
            Console.WriteLine($"Doing smth inside try, opening connection {returnValue}");
            throw new Exception();
            return returnValue;

        }
        catch (Exception ex)
        {
            returnValue += 1;
            Console.WriteLine($"Exception is cought {returnValue}");
        }
        finally
        {
            returnValue += 1;
            Console.WriteLine($"Executing finally command {returnValue}");
        }
        Console.WriteLine(returnValue);
        return returnValue;
    }

}
