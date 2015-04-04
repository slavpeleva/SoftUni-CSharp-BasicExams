using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenJumps
{
    class OddAndEvenJumps
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int oddJump= int.Parse(Console.ReadLine());
            int evenJump = int.Parse(Console.ReadLine());
            word = word.ToLower();
            word = word.Replace(" ", "");
            string oddWord = "";
            string evenWord = "";
            long oddSum = 0;
            long evenSum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddWord = oddWord + word[i];
                }
                else
                {
                    evenWord = evenWord + word[i];
                }
            }
            byte[] asciiOdd = Encoding.ASCII.GetBytes(oddWord);
            byte[] asciiEven = Encoding.ASCII.GetBytes(evenWord);
            for (int i = 0; i < asciiOdd.Length; i++)
            {
                if ((i +1) % oddJump != 0)
                {
                    oddSum = oddSum + asciiOdd[i];
                }
                else
                {
                    oddSum = oddSum * asciiOdd[i];
                }
            }
            for (int i = 0; i < asciiEven.Length; i++)
            {
                if ((i + 1)% evenJump !=0)
                {
                    evenSum = evenSum + asciiEven[i];
                }
                else
                {
                    evenSum = evenSum * asciiEven[i];
                }
            }
            Console.WriteLine("Odd: " + oddSum.ToString("X"));
            Console.WriteLine("Even: "+ evenSum.ToString("X"));
        }
    }
}
