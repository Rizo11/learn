namespace SchoolLibrary;

public class Student : Person
{
    public enum GradeLevel { Freshman, Sophomore, Junior, Senior }
    public string Grade { get; set; }

    public override float ComputeGradeAverage()
    {
        return 4.0f;
    }
}
