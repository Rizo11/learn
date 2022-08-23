using System.ComponentModel;

namespace interfaces;

public class Program1
{
    public static void Main1()
    {
        var document = new Document("monthly report");
        document.PropertyChanged += delegate(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("Property changed: {0}", e.PropertyName);
        };
        document.docName = "new name";
    }
}

public class Document
{
    public string Title { get; set; }
    public string docName { get {return Title;} 
                            set {Title = value;
                            NotifyPropChanged("docName" + value);
                            } }
    public event PropertyChangedEventHandler PropertyChanged;
    private void NotifyPropChanged(string propName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }

    public Document(string name)
    {
        Title = name;
        System.Console.WriteLine("Created a new document: " + Title);
        NotifyPropChanged("new doc instance");
    }
}