namespace SchoolLibrary;

public class EnglishPaper : IScorable
{
    public string Title { get; set; }
    public string Text { get; set; }
    public int MinWordCount { get; set; }
    public int Score { get; set; }
    public int MaxScore { get; set; }
    public int WordCount { get { return Text.WordCount(); } }
}
