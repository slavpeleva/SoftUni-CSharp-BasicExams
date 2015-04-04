using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int  i= 0; i < n - (n/2); i++)
            {
                int stars = 1 + (i * 2);
                Console.WriteLine("{0}{1}{0}",new string('-',(n - stars)/2),new string('*', stars));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}","|",new string ('*', n-2));
            }
        }
    }
}
