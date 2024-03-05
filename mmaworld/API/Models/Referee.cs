namespace API.Models
{
    public class Referee: Person
    {
       

        public int NumberOfMatche {  get; set; }

        public Referee(int numOfmatche,int id, string name, int dateOfBirth, int height, Country origin, Country placeOfBirth) : base(id, name, dateOfBirth, height, origin, placeOfBirth)
        {
            NumberOfMatche = numOfmatche;

        }
    }
}
