namespace NHLApiHelper;

public class Venue
{
    private string name;
    private string city;
    private int timezoneOffset;

    public Venue(string name, string city, int timezoneOffset)
    {
        this.name = name;
        this.city = city;
        this.timezoneOffset = timezoneOffset;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string City
    {
        get => city;
        set => city = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int TimezoneOffset
    {
        get => timezoneOffset;
        set => timezoneOffset = value;
    }
}