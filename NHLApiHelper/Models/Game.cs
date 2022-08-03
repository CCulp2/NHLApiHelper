namespace NHLApiHelper;

public class Game
{
    private int gameId;
    private Uri liveLink;
    private string gameType;
    private int season;
    private DateTime gameDate;
    private GameTeam away;
    private GameTeam home;
    private Venue venue;
    private Uri contentLink;

    public Game(int gameId, Uri liveLink, string gameType, int season, DateTime gameDate, GameTeam away, GameTeam home, Venue venue, Uri contentLink)
    {
        this.gameId = gameId;
        this.liveLink = liveLink;
        this.gameType = gameType;
        this.season = season;
        this.gameDate = gameDate;
        this.away = away;
        this.home = home;
        this.venue = venue;
        this.contentLink = contentLink;
    }

    public int GameId
    {
        get => gameId;
        set => gameId = value;
    }

    public Uri LiveLink
    {
        get => liveLink;
        set => liveLink = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string GameType
    {
        get => gameType;
        set => gameType = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Season
    {
        get => season;
        set => season = value;
    }

    public DateTime GameDate
    {
        get => gameDate;
        set => gameDate = value;
    }

    public GameTeam Away
    {
        get => away;
        set => away = value ?? throw new ArgumentNullException(nameof(value));
    }

    public GameTeam Home
    {
        get => home;
        set => home = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Venue Venue
    {
        get => venue;
        set => venue = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Uri ContentLink
    {
        get => contentLink;
        set => contentLink = value ?? throw new ArgumentNullException(nameof(value));
    }
}