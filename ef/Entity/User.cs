namespace efTest.Entity;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int age { get; set; }
    public string Password { get; internal set; }
}