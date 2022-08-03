namespace NHLApiHelper;

public class Division
{
    private int id;
    private string name;
    private string nameShort;
    private string abbreviation;
    private Conference conference;
    private bool active;

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string NameShort
    {
        get => nameShort;
        set => nameShort = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Abbreviation
    {
        get => abbreviation;
        set => abbreviation = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Conference Conference
    {
        get => conference;
        set => conference = value;
    }

    public bool Active
    {
        get => active;
        set => active = value;
    }
}