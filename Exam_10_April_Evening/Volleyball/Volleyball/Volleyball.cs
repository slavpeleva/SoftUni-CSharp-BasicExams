using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            float p = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            float playedGames = h;
            float normalWeek = ((48 - h) * 3) / 4;
            float holidays = (p * 2) / 3;
            float sum = playedGames + normalWeek + holidays;
            if (year == "leap")
            {
                sum = sum + (sum * 0.15f);
            }
            Console.WriteLine((int)sum);
        }
    }
}
