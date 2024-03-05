namespace API.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Host Host { get; set; }
        public List<Match> Matches { get; set; }

        public Event(int id, string name, Host host, List<Match> matches)
        {
            Id = id;
            Name = name;
            Host = host;
            Matches = new List<Match>();
        }
    }
}
