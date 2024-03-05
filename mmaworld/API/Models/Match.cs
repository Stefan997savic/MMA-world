namespace API.Models
{
    public class Match
    {
        public int Id { get; set; }
        public Fighter BlueFigter { get; set; }

        public Fighter RedFighter { get; set; }

        public Referee Referee { get; set; }

        public Fighter Winner {  get; set; }

        public ScoreType ScoreType { get; set; }

        public TimeSpan TimeElapsed { get; set; }

        public Match(int id, Fighter blueFigter, Fighter redFighter, Referee referee, Fighter winner, ScoreType scoreType, TimeSpan timeElapsed)
        {
            Id = id;
            BlueFigter = blueFigter;
            RedFighter = redFighter;
            Referee = referee;
            Winner = winner;
            ScoreType = scoreType;
            TimeElapsed = timeElapsed;
        }
    }
}
