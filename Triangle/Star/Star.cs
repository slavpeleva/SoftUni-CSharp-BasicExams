using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star
{
    class Star
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}",new string('.',n),'*');
            for (int i = 0; i < n/2-1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (((2 * n + 1) - 2) - (i * 2 + 1)) / 2), "*", new string('.', i * 2 + 1));
            }

            Console.WriteLine("{0}{1}{0}", new string('*',(n/2+1)),new string('.', n-1));
            for (int i = 0; i < n/2 -1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",new string('.', i+1),"*",new string('.',(n*2+1)-2 -2*(i+1)));
            }

            Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}",new string('.',n/2),"*",new string('.',((n*2+1)-n -3)/2));
            for (int i = 0; i < n/2-1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",new string('.',((n*2+1)-4 - (i*2+1)-2*(n/2-1))/2),"*",new string('.', n/2 -1),new string('.', i*2+1));
            }

            Console.WriteLine("{0}{1}{0}", new string('*', (n / 2 + 1)), new string('.', n - 1));


        }
    }
}
