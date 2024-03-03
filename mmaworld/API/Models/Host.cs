namespace API.Models
{
    public class Host
    {
        public int HostId { get; set; }

        public string Arena { get; set; }

        public string City { get; set; }

        public int Attendance { get; set; }

        public int Capacity { get; set; }

        public Country Country { get; set; }

        public Host(int id, string name, string iSO2, string iSO3, string nameSRB, Country country)
        {
            HostId = id;
            Arena = nameSRB;
            City = nameSRB;
            Attendance = 0;
            Capacity = 0;
            Country = country;
        }
    }
}
