using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            float rows = float.Parse(Console.ReadLine());
            float columns = float.Parse(Console.ReadLine());
            if (projection == "Premiere")
            {
                Console.WriteLine("{0:0.00} leva", (rows *columns)*12.00);
            }
            else if (projection == "Normal")
            {
                Console.WriteLine("{0:0.00} leva",(rows * columns) * 7.50);
            }
            else if (projection == "Discount")
            {
                Console.WriteLine("{0:0.00} leva",(rows * columns) * 5.00);
            }
        }
    }
}
