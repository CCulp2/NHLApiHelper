namespace NHLApiHelper.Models.DTOs;

public class ScheduleDTO
{
    public class MetaData
    {
        public string TimeStamp { get; set; }
    }

    public class Status
    {
        public string AbstractGameState { get; set; }
        public string CodedGameState { get; set; }
        public string DetailedState { get; set; }
        public string StatusCode { get; set; }
        public bool StartTimeTBD { get; set; }
    }

    public class LeagueRecord
    {
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ot { get; set; }
        public string Type { get; set; }
    }

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
    }

    public class Away
    {
        public LeagueRecord LeagueRecord { get; set; }
        public int Score { get; set; }
        public Team Team { get; set; }
    }

    public class Home
    {
        public LeagueRecord LeagueRecord { get; set; }
        public int Score { get; set; }
        public Team Team { get; set; }
    }

    public class Teams
    {
        public Away Away { get; set; }
        public Home Home { get; set; }
    }

    public class Venue
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public int? Id { get; set; }
    }

    public class Content
    {
        public string Link { get; set; }
    }

    public class Game
    {
        public int GamePk { get; set; }
        public string Link { get; set; }
        public string GameType { get; set; }
        public string Season { get; set; }
        public DateTime GameDate { get; set; }
        public Status Status { get; set; }
        public Teams Teams { get; set; }
        public Venue Venue { get; set; }
        public Content Content { get; set; }
    }

    public class Date
    {
        public string Date { get; set; }
        public int TotalItems { get; set; }
        public int TotalEvents { get; set; }
        public int TotalGames { get; set; }
        public int TotalMatches { get; set; }
        public IList<Game> Games { get; set; }
        public IList<object> Events { get; set; }
        public IList<object> Matches { get; set; }
    }

    public class Example
    {
        public string Copyright { get; set; }
        public int TotalItems { get; set; }
        public int TotalEvents { get; set; }
        public int TotalGames { get; set; }
        public int TotalMatches { get; set; }
        public MetaData MetaData { get; set; }
        public int Wait { get; set; }
        public IList<Date> Dates { get; set; }
    }
}