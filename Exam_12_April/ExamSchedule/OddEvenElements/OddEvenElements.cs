using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenElements
{
    class OddEvenElements
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            float[] realNumbs = new float[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                realNumbs[i] = float.Parse(numbers[i]);
            }            
            float oddSum = 0;
            float oddMin = float.MaxValue;
            float oddMax = float.MinValue;
            float evenSum = 0;
            float evenMin = float.MaxValue;
            float evenMax = float.MinValue;
            bool hasEven = true;
            for (int position = 0; position < realNumbs.Length; position++)
            {
                if (position%2 == 0)
                {
                    oddSum = oddSum + realNumbs[position];
                    if (realNumbs[position] < oddMin)
                    {
                        oddMin = realNumbs[position];
                    }
                    if (realNumbs[position] > oddMax)
                    {
                        oddMax = realNumbs[position];
                    }
                        
                }
                else
                {
                    hasEven = false;
                    evenSum = evenSum +realNumbs[position];
                    if (realNumbs[position] < evenMin)
                    {
                        evenMin = realNumbs[position];
                    }
                    if (realNumbs[position] > evenMax)
                    {
                        evenMax = realNumbs[position];
                    }
                }
            }
            if (hasEven)
            {
                Console.WriteLine("OddSum = {0}, OddMin = {1}, OddMax = {2}, EvenSum = No, EvenMin = No, EvenMax = No", oddSum, oddMin, oddMax);
            }
            else
            {
                Console.WriteLine("OddSum = {0}, OddMin = {1}, OddMax = {2}, EvenSum = {3}, EvenMin = {4}, EvenMax = {5}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
            }
                        

        }
    }
}
