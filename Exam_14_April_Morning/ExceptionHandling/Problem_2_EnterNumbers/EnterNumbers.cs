using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isValid = false;
                do
                {
                    try
                    {
                        //to prevent endless cycle we decrease the value of end
                        int n = ReadNumber(start, end - (10-i));
                        if ( i > 0 && n <= numbers[i - 1])
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        numbers[i] = n;
                        isValid = true;
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                        Console.WriteLine("Number must be bigger than " + numbers[i - 1]);
                    }
                } while (!isValid);
              
            }
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
        }
        public static int ReadNumber(int start, int end)
        {
            while (true)
            {


                string number = Console.ReadLine();
                try
                {
                    int numb = int.Parse(number);
                    if (numb <= start || numb >= end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return numb;
                }
                catch (ArgumentOutOfRangeException)
                {

                    Console.WriteLine("number must be bigger than {0} and smaller than {1}", start, end);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number");
                }
            }
        }
    }
}
