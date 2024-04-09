using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Class1
    {
        public Class1()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISO2 { get; set; }
        public string ISO3 { get; set; }
        public string NameSRB { get; set; }

        public Class1(int id,
            string name,
            string iSO2,
            string iSO3,
            string nameSRB)
        {
            Id = id;
            Name = name;
            ISO2 = iSO2;
            ISO3 = iSO3;
            NameSRB = nameSRB;
        }

        public override string ToString()
        {
            return Id + "  " + Name + "  " + ISO2 + "  " + ISO3 + "  " + NameSRB;
        }

        public string GetISO3ShortCode()
        {
            return ISO3;
        }
        public string GetSerbianName()
        {
            return NameSRB;
        }
    }
}

