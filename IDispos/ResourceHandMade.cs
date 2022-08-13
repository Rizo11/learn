namespace IDispos;
public class ResourceHandMade : IDisposable
{
    // class of method Dispose()
    private bool disposed = false;
    

    // for user calls
    public void Dispose()
    {
        System.Console.WriteLine("Dispose() called");
        // If true, cleaning was initiated by user class, by calling Dispose() method.
        CleanUp(true);

        // Cancels usage of destructor
        // SuppressFinalize tells the GC that the object was cleaned up properly and doesn't need to go onto the finalizer queue.
        GC.SuppressFinalize(this);
    }

    // GC will call destructor if user forgot to call Dispose()
    ~ResourceHandMade()
    {
        Console.WriteLine("Destructor called");
        CleanUp(false);
    }

    // method for not writing the same code in Destructor and Dispose()
    private void CleanUp(bool clean)
    {
        // if resources are not cleaned up yet
        if(!this.disposed)
        {
            if(clean)
            {
                Console.WriteLine("Cleaning up managed resources");
            }
            System.Console.WriteLine("Cleaning up unmanaged resources");
        }
        this.disposed = true;
    }
    public void DoWork()
    {
        // if user uses already disposed object, it will throw an exception
        if(disposed)
        {
            throw new ObjectDisposedException("ResourceHandMade");
        }
        System.Console.WriteLine("Doing work inside ResourceHandMade");
    }
}

// finalizer = Finalizers are meant as a mechanism to release resources 
// not controlled by garbage collector, like an unmanaged handle. While Dispose might do it, it isn't guaranteed that the consumer will call it.

// Since C# is garbage collected, a destructor is only useful for cleaning up resources that wouldn't otherwise be automatically cleaned up.

// The finalizer queue holds all objects that have a finalizer method defined. Recall that a finalizer is a means to collect unmanaged resources like handles.
// When the garbage collector collects garbage, it moves any objects with a finalizer into the finalizer queue. At some point later-- depending
// on memory pressure, GC heuristics, and the phase of the moon-- when the garbage collector decides to collect these objects, it walks down the
// queue and runs the finalizers.