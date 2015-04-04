using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfElements
{
    class SumOfElements
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] nums = n.Split(' ', '\t');
            
            double[] realNums = new double[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                realNums[i] = double.Parse(nums[i]); 
                    
                    
            }
            Array.Sort(realNums);
            double minVal = 0;
            for (int i = 0; i < realNums.Length-1; i++)
            {
                minVal = minVal + realNums[i];
               
            }
            if (minVal == realNums[realNums.Length - 1])
            {
                Console.WriteLine("Yes, sum=" + minVal);
            }
            else if (realNums[realNums.Length -1] > minVal)

            {
                Console.WriteLine("No, diff=" + (realNums[realNums.Length - 1] - minVal));
            }
            else
            {
                Console.WriteLine("No, diff=" + (minVal - realNums[realNums.Length - 1]));
            }
           
            
        }
    }
}
