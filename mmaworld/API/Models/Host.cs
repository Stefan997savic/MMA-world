namespace API.Models
{
    public class Host: Country
    {
        public int Id { get; set; }

        public string Arena { get; set; }

        public string City { get; set; }

        public int Attendance { get; set; }

        public int Capacity { get; set; }
    }
}
