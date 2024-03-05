namespace API.Models
{
    public class Person
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public int DateOfBirth {  get; set; }

        public int Height { get; set; }

        public Country Origin { get; set; }

        public Country PlaceOfBirth { get; set; }



        public Person(int id, 
                        string name, 
                        int dateOfBirth, 
                        int height, 
                        Country origin, 
                        Country placeOfBirth)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Height = height;
            Origin = origin;
            PlaceOfBirth = placeOfBirth;
        }
    }
}
