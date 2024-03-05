using System.Xml.Linq;

namespace API.Models
{
    //TODO do same for Country as it is at host 
    public class Organization
    {
       

        public int OrgID { get; set; } 
        public string OrgName {  get; set; } 
        public string ShortName {  get; set; }

        public Country Country { get; set; }

        public Organization(int id, string name,string shortName, Country country)
        {
            OrgID = id;
            OrgName = name;
            ShortName = shortName;
            Country = country;
            


        }



    }
}
