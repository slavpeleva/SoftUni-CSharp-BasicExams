﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class NumbersIntervalDividableGivenNumber
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = start; i <= end; i++)
            {
                if (i%5 == 0)
                {
                    p++;
                    
                }
            }
            Console.Write(p);
        }
    }

