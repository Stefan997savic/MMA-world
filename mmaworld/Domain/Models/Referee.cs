namespace Domain.Models
{
    public class Referee : Person
    {
        public int NumberOfMatches { get; set; }

        public Referee(int numOfmatche,
            int id,
            string name,
            int dateOfBirth,
            int height,
            Country origin,
            Country placeOfBirth)
            : base(id, name, dateOfBirth, height, origin, placeOfBirth)
        {
            NumberOfMatches = numOfmatche;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
