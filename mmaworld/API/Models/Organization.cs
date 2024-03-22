using System.Xml.Linq;

namespace API.Models
{
    //TODO do same for Country as it is at host 
    public class Organization
    {
        public int Id { get; set; } 
        public string OrgName {  get; set; } 
        public string ShortName {  get; set; }
        public Country Country { get; set; }
        public List<Event> Events { get; set; }

        public Organization(int id, 
                            string name, 
                            string shortName, 
                            Country country, 
                            List<Event> events)
        {
            Id = id;
            OrgName = name;
            ShortName = shortName;
            Country = country;
            Events = events;
        }

       
        public Organization(int id,
                           string name,
                           string shortName,
                           Country country)
        {
            Id = id;
            OrgName = name;
            ShortName = shortName;
            Country = country;
            Events = new List<Event>();
        }

    }
}
