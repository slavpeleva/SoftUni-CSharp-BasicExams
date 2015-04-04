using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            try
            {
                int numb = int.Parse(number);
                if (numb < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine(Math.Sqrt(numb));
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("Invalid number");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid number");

            }
            finally 
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
