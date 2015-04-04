using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eclipse
{
    class Eclipse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" {0} {1} {0} ", new string('*',(n*2)-2),new string(' ', n-1));
            for (int row = 0; row < n - 2; row++)
            {
                if (n / 2 == row + 1)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/',(n*2)-2),new string('-', n-1));
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', (n * 2) - 2), new string(' ', n - 1));
                }
            }



            Console.WriteLine(" {0} {1} {0} ", new string('*', (n * 2) - 2), new string(' ', n - 1));
        }
    }
}
