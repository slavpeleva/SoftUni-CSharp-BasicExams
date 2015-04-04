using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = a + b;
            if (n == 1)
            {
                Console.Write(a);
            }
            else if (n == 2)
            {
                Console.Write(a +" " + b);
            }
            else if (n == 3)
            {
                Console.Write(a +" "+ b +" "+c);
            }
            else
            {
                Console.Write(a + " " + b + " " + c);
                for (int i = 0; i < n- 3 ; i++)
                {
                    a = b;
                    b = c;
                    c = a + b;
                    Console.Write(" " + c);
                }
            }
        }
    }

