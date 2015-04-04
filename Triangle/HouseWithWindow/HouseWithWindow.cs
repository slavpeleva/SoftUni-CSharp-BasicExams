﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseWithWindow
{
    class HouseWithWindow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}",new string('.', n-1),'*');
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (((2 * n - 1) - 2) - (i * 2 + 1))/2), "*", new string('.', i * 2 + 1));
            }
            Console.WriteLine(new string('*',2*n - 1));
            for (int i = 0; i < n/4; i++)
            {
                Console.WriteLine("{0}{1}{0}", "*", new string('.', (2*n - 1)-2));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}","*", new string('.',(((2*n - 1)- 2)-(n-3))/2),new string('*',n-3));
            }
            
            
            
            for (int i = 0; i < n / 4; i++)
            {
                Console.WriteLine("{0}{1}{0}", "*", new string('.', (2 * n - 1) - 2));
            }

            Console.WriteLine(new string('*', 2*n-1));

        }
    }
}
