namespace Domain.Models
{
    public class ScoreType
    {

        public int Id {  get; set; }

        public string Name { get; set; }

        public ScoreType(int id, 
                         string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
