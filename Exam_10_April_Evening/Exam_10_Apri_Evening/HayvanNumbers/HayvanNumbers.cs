﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanNumbers
{
    class HayvanNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            bool hasResult = true;
            for (int a = 5; a <= 9; a++)
            {
                for (int b = 5; b <= 9; b++)
                {
                    for (int c= 5; c <= 9; c++)
                    {
                        for (int d = 5; d <= 9; d++)
                        {
                            for (int e = 5; e <=9; e++)
                            {
                                for (int f = 5; f <=9; f++)
                                {
                                    for (int g = 5; g <=9; g++)
                                    {
                                        for (int h = 5; h <=9; h++)
                                        {
                                            for (int i = 5; i <= 9 ; i++)
                                            {
                                                int abc = (a * 100) + (b * 10) + c;
                                                int def = (d * 100) + (e * 10) + f;
                                                int ghi = (g * 100) + (h * 10) + i;
                                                if (ghi-def == diff && def-abc == diff)
                                                {
                                                    if (a+b + c + d + e + f + g+ h+ i == sum)
                                                    {
                                                        hasResult = false;
                                                        Console.WriteLine(a+""+b+""+c+""+d+""+e+""+f+""+g+""+h+""+i);
                                                    }    
                                                }

                                            }
                                        }
                                    }
                                }
                                
                            }
                        }
                    }
                }
            }
            if (hasResult)
            {
                Console.WriteLine("No");
            }

        }
    }
}
