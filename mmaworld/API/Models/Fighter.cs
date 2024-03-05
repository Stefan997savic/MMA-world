namespace API.Models
{
    public class Fighter: Person
    {
        

        public string NickName { get; set; }

        public string Record {  get; set; }

        public Fighter(string nick,string record,int id, string name, int dateOfBirth, int height, Country origin, Country placeOfBirth) : base(id, name, dateOfBirth, height, origin, placeOfBirth)
        {
            NickName = nick;
            Record = record;

        }


    }
}
