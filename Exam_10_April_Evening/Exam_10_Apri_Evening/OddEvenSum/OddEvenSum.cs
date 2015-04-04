using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
            for (int i = 0; i < n*2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i %2 == 0)
                {
                    even = even + number;
                }
                else
                {
                    odd = odd + number;
                }
            }
            if (odd == even)
            {
                Console.WriteLine("Yes, sum=" + odd);
            }
            else
            {
                int diff = odd - even;
                if (diff <0)
                {
                    diff = diff * (-1);
                }
                Console.WriteLine("No, diff=" + diff);
            }
        }
    }
}
