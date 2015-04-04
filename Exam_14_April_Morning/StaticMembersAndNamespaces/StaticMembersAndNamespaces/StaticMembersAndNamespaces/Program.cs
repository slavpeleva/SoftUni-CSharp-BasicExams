using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D t1 = new Point3D(2, 4, 1);
            Point3D t2 = Point3D.StartingPoint;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
    }
}
