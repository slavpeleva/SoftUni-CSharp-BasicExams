using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Electricity
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());
            string hours = Console.ReadLine();
            string[] realHours = hours.Split(':');
            int curHour = int.Parse(realHours[0]);
            double wats = 0;
            if (curHour >= 0 && curHour < 9 )
            {
                wats = (100.53 + (8 * 125.9))*flats*floors;

            }
            else if (curHour >= 19 && curHour < 24)
            {
                wats = ((7*100.53) + (6 * 125.9)) * flats * floors;
            }
            else if (curHour >= 14 && curHour < 19)
	        {
                wats = ((2*100.53) + (2 * 125.9)) * flats * floors;
	        }
            Console.WriteLine((int)wats + " Watts");
        }
    }
}
