using StaticMembersAndNamespaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D t1 = new Point3D(2,17,2);
            Point3D zeroPoint = Point3D.StartingPoint;
            Console.WriteLine(DistanceCalculator.CalcDist(t1,zeroPoint));
        }
    }
}
