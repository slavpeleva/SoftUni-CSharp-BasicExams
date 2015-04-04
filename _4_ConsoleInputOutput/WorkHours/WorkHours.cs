using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class WorkHours
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double workDays = days - (days * 0.1);
            double workHours = workDays * 12;
            double productivity = workHours * (percent / 100);
            int productHours = (int)productivity - hours;
            if (productHours < 0)
            {
                Console.WriteLine("No");
                Console.WriteLine(productHours);
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine(productHours);
            }

        }
    }

