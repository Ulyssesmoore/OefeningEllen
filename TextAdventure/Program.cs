using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            Console.WriteLine("Wijziging voor git");
            //int i = Convert.ToInt32(Console.ReadLine());
            //if (i == 0)
            for (;;)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i != 0)
                {
                    Console.WriteLine(i * 2);
                }
            
                if (i == 0)
                {
                    break;
                }
                  
            }







        }
    }
}
