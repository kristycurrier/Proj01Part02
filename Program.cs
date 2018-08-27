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

            DateTime date1 = DateTime.Parse("1/1/1");
            DateTime date2 = DateTime.Parse("1/1/1");
            bool date1bool = false;
            bool date2bool = false;

            Console.WriteLine("Enter two dates for the time between them in days, hours and minutes.");  //Asking for user input

            while (date1bool == false)    //checking that the first date entered is a valid date
            {
                Console.WriteLine("Please enter first date: ");
                date1bool = DateTime.TryParse(Console.ReadLine(), out date1);//Taking in sting and turning it in a DateTime variable
            }

            while (date2bool == false)      //checking second date is valid date
            {
                Console.WriteLine("Please enter second date: ");
                date2bool = DateTime.TryParse(Console.ReadLine(), out date2);    //Taking in sting and turning it in a DateTime variable
            }

            double dateDiff;

            if (date2 > date1)                                                 //checking that date2 is larger then date1
            {
                dateDiff = (date2 - date1).Days;
            }
            else                                                               //else statement if date2 is smaller then date1
            {
                dateDiff = (date1 - date2).Days;
            }
            double dateDiffhours = dateDiff * 24;                             //Multiply days by 24 hours for total hours
            double dateDiffmin = dateDiffhours * 60;                          //Multiply hours by 60 minutes for total minutes



            /*Print all days, hours and seconds for user*/

            Console.WriteLine("Difference in days: " + dateDiff.ToString());
            Console.WriteLine("Difference in hours: " + dateDiffhours.ToString());
            Console.WriteLine("Difference in seconds: " + dateDiffmin.ToString());
            Console.ReadKey();
            
        }
    }
}
