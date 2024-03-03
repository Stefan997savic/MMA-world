using System.Xml.Linq;

namespace API.Models
{
    //TODO do same for Country as it is at host 
    public class Organization: Country
    {
       

        public int OrgID { get; set; } 
        public string OrgName {  get; set; } 
        public string ShortName {  get; set; }

        public Organization(int id, string name, string iSO2, string iSO3, string nameSRB) : base(id, name, iSO2, iSO3, nameSRB)
        {
            OrgID = id; 
            OrgName = name; 
            ShortName = iSO2;


        }



    }
}
