namespace SchoolLibrary;

public abstract class Person
{
    public string FullName { get; set; }
    public string Email { get; set; }

    public abstract float ComputeGradeAverage();

    public virtual string SendMessage()
    {
        return string.Format("sent at {0:D} {0:t}", DateTime.Now);
    }
}
