namespace API.Models
{
    public class ScoreType
    {

        public int Id {  get; set; }

        public Fighter Name { get; set; }

        public ScoreType(int id, Fighter name)
        {
            Id = id;
            Name = name;
        }
    }
}
