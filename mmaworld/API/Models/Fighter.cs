namespace API.Models
{
    public class Fighter
    {
        public string NickName { get; set; }

        public string Record {  get; set; }


        public Fighter(string nick,string record) 
        {
            NickName = nick;
            Record = record;
        }

    }
}
