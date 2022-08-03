namespace NHLApiHelper;

public class Team
{
    private int id;
    private string name;
    private string link;
    private Venue venue;
    private string abbreviation;
    private string teamName;
    private string locationName;
    private int firstYearOfPlay;
    private Division division;
    private Conference conference;
    private Franchise franchise;
    private string shortName;
    private Uri officialSiteUri;
    private int franchiseId;
    private bool active;

    public Team(int id, string name, string link, Venue venue, string abbreviation, string teamName, string locationName, int firstYearOfPlay, Division division, Conference conference, Franchise franchise, string shortName, Uri officialSiteUri, int franchiseId, bool active)
    {
        this.id = id;
        this.name = name;
        this.link = link;
        this.venue = venue;
        this.abbreviation = abbreviation;
        this.teamName = teamName;
        this.locationName = locationName;
        this.firstYearOfPlay = firstYearOfPlay;
        this.division = division;
        this.conference = conference;
        this.franchise = franchise;
        this.shortName = shortName;
        this.officialSiteUri = officialSiteUri;
        this.franchiseId = franchiseId;
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

    public string Link
    {
        get => link;
        set => link = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Venue Venue
    {
        get => venue;
        set => venue = value;
    }

    public string Abbreviation
    {
        get => abbreviation;
        set => abbreviation = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string TeamName
    {
        get => teamName;
        set => teamName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string LocationName
    {
        get => locationName;
        set => locationName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int FirstYearOfPlay
    {
        get => firstYearOfPlay;
        set => firstYearOfPlay = value;
    }

    public Division Division
    {
        get => division;
        set => division = value;
    }

    public Conference Conference
    {
        get => conference;
        set => conference = value;
    }

    public Franchise Franchise
    {
        get => franchise;
        set => franchise = value;
    }

    public string ShortName
    {
        get => shortName;
        set => shortName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Uri OfficialSiteUri
    {
        get => officialSiteUri;
        set => officialSiteUri = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int FranchiseId
    {
        get => franchiseId;
        set => franchiseId = value;
    }

    public bool Active
    {
        get => active;
        set => active = value;
    }
}