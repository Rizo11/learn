namespace SchoolLibrary;

public class School
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Zip { get; set; }
    public string Phone { get; set; }
    public string Website { get; set; }
    public string Email { get; set; }
    public string YearEstablished { get; set; }
    private string _telegramNick;
    public string TelegramNick
    {
        get { return _telegramNick; }
        set 
        {
            if (value.StartsWith("@"))
                _telegramNick = value;
            else
                throw new Exception("Telegram nick should start with '@'");
        }
    }

    public School(string name = "Unknown", string address = "Unknown", string zip = "Unknown", string phone = "Unknown",
                    string website = "Unknown", string email = "Unknown", string yearEstablished = "Unknown")
    {
        Name = name;
        Address = address;
        Zip = zip;
        Phone = phone;
        Website = website;
        Email = email;
        YearEstablished = yearEstablished;
    }

    public static int averageThree(int a, int b, int c)
    {
        return (a + b + c) / 3;
    }
    public static float averageThree(float a, float b, float c) => (a + b + c) / 3;

    public override string ToString()
    {
        return Name + "\n" + Address + "\n" + Phone + " " + Website + " " + Email + "\n";
    }
}
