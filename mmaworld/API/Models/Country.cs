namespace API.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISO2 { get; set; }
        public string ISO3 { get; set; }
        public string NameSRB { get; set; }



        public Country(int id, string name, string iSO2, string iSO3, string nameSRB)
        {
            this.Id = id;
            this.Name = name;
            this.ISO2 = iSO2;
            this.ISO3 = iSO3;
            this.NameSRB = nameSRB;
        }
    }
}
