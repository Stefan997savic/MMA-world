using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPersistance
{

    public static class Exstentions
    {
        public static void PrintList(this List<Country> list)
        {
            Console.WriteLine("***List dump:***");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }



}
