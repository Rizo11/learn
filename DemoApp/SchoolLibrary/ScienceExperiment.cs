namespace SchoolLibrary;

public class ScienceExperiment : IScorable
{
    public string Title { get; set; }
    public string Instruments { get; set; }
    public string Results { get; set; }
    public int Score { get; set; }
    public int MaxScore { get; set; }
}
