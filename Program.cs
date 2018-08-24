using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj01Part02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string line = Console.ReadLine();
            DateTime dt;
            while (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
            {
                Console.WriteLine("Invalid date, please retry");
                line = Console.ReadLine();
            }
            */
            DateTime date1;
            DateTime date2;

            Console.WriteLine("Enter two dates for the time between them in days, hours and minutes.");
            Console.WriteLine("Please enter first date: ");
            date1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second date: ");
            date2 = DateTime.Parse(Console.ReadLine());



            Console.WriteLine(date1.ToString());
            Console.ReadKey();
            
        }
    }
}
