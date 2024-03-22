namespace Domain.Models
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
            Matches = matches;
        }
        public Event(int id, string name, Host host)
        {
            Id = id;
            Name = name;
            Host = host;
            Matches = new List<Match>();
        }
        public override string ToString()
        {
            return $"{Name} [{Host}]";
        }
    }
}
