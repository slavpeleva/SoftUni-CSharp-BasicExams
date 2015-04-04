using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersAndNamespaces
{
    public class Point3D
    {
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);
        private double x;
        private double y;
        private double z;
        public Point3D(double inputX,double inputY, double inputZ)
        {
            this.X = inputX;
            this.Y = inputY;
            this.Z = inputZ;
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public double Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }
        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }
        public static Point3D StartingPoint 
        {
            get
            {
                return startingPoint;
            }
            
        }
        public override string ToString()
        {
            return string.Format("Point with coordinates x:{0}, y:{1}, z:{2}", this.x,this.y,this.z);
        }

    }
}
