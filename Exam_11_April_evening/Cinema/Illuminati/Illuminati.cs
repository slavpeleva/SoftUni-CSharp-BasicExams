using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illuminati
{
    class Illuminati
    {
        static void Main(string[] args)
        {
            string msg = Console.ReadLine();
            msg = msg.ToLower();
            int letters = 0;
            int sumLet = 0;
            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] == 'a')
                {
                    letters++;
                    sumLet = sumLet + 65;
                }
                else if (msg[i] == 'e')
                {
                    letters++;
                    sumLet = sumLet + 69;
                }
                else if (msg[i] == 'i')
                {
                    letters++;
                    sumLet = sumLet + 73;
                }
                else if (msg[i] == 'o')
                {
                    letters++;
                    sumLet = sumLet + 79;
                }
                else if (msg[i] == 'u')
                {
                    letters++;
                    sumLet = sumLet + 85;
                }
            }
            Console.WriteLine(letters);
            Console.WriteLine(sumLet);
        }
    }
}
