namespace NHLApiHelper;

public class GameTeam
{
    private LeagueRecord leagueRecord;
    private Team team;

    public GameTeam(LeagueRecord leagueRecord, Team team)
    {
        this.leagueRecord = leagueRecord;
        this.team = team;
    }

    public LeagueRecord LeagueRecord
    {
        get => leagueRecord;
        set => leagueRecord = value;
    }

    public Team Team
    {
        get => team;
        set => team = value ?? throw new ArgumentNullException(nameof(value));
    }
}