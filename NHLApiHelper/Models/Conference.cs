namespace NHLApiHelper;

public class Conference
{
    private int id;
    private string name;
    private string abbreviation;
    private string shortName;
    private bool active;

    public Conference(int id, string name, string abbreviation, string shortName, bool active)
    {
        this.id = id;
        this.name = name;
        this.abbreviation = abbreviation;
        this.shortName = shortName;
        this.active = active;
    }

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

    public string Abbreviation
    {
        get => abbreviation;
        set => abbreviation = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string ShortName
    {
        get => shortName;
        set => shortName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool Active
    {
        get => active;
        set => active = value;
    }
}