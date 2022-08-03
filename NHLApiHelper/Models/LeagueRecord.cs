namespace NHLApiHelper;

public class LeagueRecord
{
    private int wins;
    private int losses;
    private int ot;

    public LeagueRecord(int wins, int losses, int ot)
    {
        this.wins = wins;
        this.losses = losses;
        this.ot = ot;
    }

    public int Wins
    {
        get => wins;
        set => wins = value;
    }

    public int Losses
    {
        get => losses;
        set => losses = value;
    }

    public int Ot
    {
        get => ot;
        set => ot = value;
    }
}