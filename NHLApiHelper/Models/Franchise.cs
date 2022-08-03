namespace NHLApiHelper;

public class Franchise
{
    private int id;
    private int firstSeasonId;
    private int mostRecentTeamId;
    private string teamName;
    private string locationName;

    public Franchise(int id, int firstSeasonId, int mostRecentTeamId, string teamName, string locationName)
    {
        this.id = id;
        this.firstSeasonId = firstSeasonId;
        this.mostRecentTeamId = mostRecentTeamId;
        this.teamName = teamName;
        this.locationName = locationName;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public int FirstSeasonId
    {
        get => firstSeasonId;
        set => firstSeasonId = value;
    }

    public int MostRecentTeamId
    {
        get => mostRecentTeamId;
        set => mostRecentTeamId = value;
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
}