using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSchedule
{
    class ExamSchedule
    {
        static void Main(string[] args)
        {
            int startHours = int.Parse(Console.ReadLine());
            int startMins = int.Parse(Console.ReadLine());
            string noon = Console.ReadLine();
            int endHours = int.Parse(Console.ReadLine());
            int endMins = int.Parse(Console.ReadLine());
            int sumHours = startHours + endHours;
            int sumMins = startMins + endMins;
            if (sumMins > 59)
            {
                sumMins = sumMins - 60;
                sumHours++;
            }
            if (sumHours>= 12)
            {
                if (sumHours == 12)
                {
                    if (noon == "PM")
                    {
                        noon = "AM";
                    }
                    else
                    {
                        noon = "PM";
                    }
                }
                else {
                    sumHours = sumHours - 12;
                    if (noon == "PM")
                    {
                        noon = "AM";
                    }
                    else
                    {
                        noon = "PM";
                    }
                }

            }
            Console.WriteLine("{0:00}:{1:00}:{2}", sumHours,sumMins,noon);
        }
    }
}
