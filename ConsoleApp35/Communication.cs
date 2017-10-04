using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Communication
    {
        public static void ErrorMessage() => Console.WriteLine("Ej giltigt nummer.\n");
        
        public static void FirstChoice()
        {
            Console.WriteLine("Välj lista ett nummer i nedanstående lista");

            foreach (string item in Lists.mainList)
            {
                Console.WriteLine("{0} ",item);
            }
        }
    }
}