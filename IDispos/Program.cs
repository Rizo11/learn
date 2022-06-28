namespace IDispos;

public class Program
{
    public static void Main()
    {
        // memory cleaning in c#
        // why IDisposable? Release unmanaged resources
        // what is Unmanaged? Unmanaged resources GC does not know

        // creating class with IDisposable

        // using class with IDisposable
        # region Using Hand made
        using(ResourceHandMade resource = new ResourceHandMade())
        {
            resource.DoWork();
        }
        System.Console.WriteLine("~~~~~~~~~~~~~~~");

        var sr = new ResourceHandMade();
        try
        {
            System.Console.WriteLine("inside try");
        }
        finally
        {
            if(sr != null) sr.Dispose();
            // sr.DoWork();
        }
        
        System.Console.WriteLine("~~~~~~~~~~~~~~~");
        sr = new ResourceHandMade();
        sr.DoWork();
        #endregion
    
        #region Using built in classes
        // there are 2 ways to use IDisposable
        // 1. using(var resource = new ResourceHandMade())
        // 2. try finally

        # region using
        using(var reader = new StreamReader("file.txt"))
        {
            System.Console.WriteLine("reading from stream reader with using");;
        }
        #endregion

        #region try finally
        StreamReader reader2 = null;
        try
        {
            reader2 = new StreamReader("file.txt");
            System.Console.WriteLine("reading from stream reader with try finally");
        }
        finally
        {
            if(reader2 != null) reader2.Dispose();
        }
        #endregion

        #endregion
    }
}

// using System.Runtime.InteropServices;

// namespace System
// {
//     
//      Summary:
//          Provides a mechanism for releasing unmanaged resources.
//     [ComVisible(true)]
//     [__DynamicallyInvokable]
//     public interface IDisposable
//     {
//         
//          Summary:
//              Performs application-defined tasks associated with freeing, releasing, or resetting
//              unmanaged resources.
//         [__DynamicallyInvokable]
//         void Dispose();
//     }
// }
// #if false // Decompilation log
// '25' items in cache
// #endif
