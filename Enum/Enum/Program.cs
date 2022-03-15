using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Wednesday);
            Console.WriteLine((int)Days.Thursday);// that's showing the day's index (hint: wednesday is third day in a week but it's index is 2)


            int temp = 40;
            if (temp <= (int)Temperature.Hot && temp >= (int)Temperature.Cold)
            {
                Console.WriteLine("what a gorgeous day!! Let's go out");

            }

        }
        enum Days
        {
           Monday,
           Tuesday,
           Wednesday,
           Thursday,
           Friday,
           Saturday,
           Sunday
        }
        enum Temperature
        {
            VeryCold = -5,
            Cold = 5,
            Normal = 15,
            Hot=30,

            
        }
    }
}
