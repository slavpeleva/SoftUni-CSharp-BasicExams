using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_ToePower
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            
           
            Console.WriteLine(Math.Pow(v+(y*3+x),(y*3+x+1)));
           
        }
    }
}
