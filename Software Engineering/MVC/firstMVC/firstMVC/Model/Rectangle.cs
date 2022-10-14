using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstMVC.Model
{
    class Rectangle
    {
        double sideA;
        double sideB;

        private double SideA 
        {
            get { return sideA; }
            set { sideA = value; }
        }

        private double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public Rectangle (double sideA, double sideB) 
        {
            SideA = sideA;
            SideB = sideB;
        }

        public Rectangle() : this(0, 0) { }

        public double Perimeter() 
        {
            return (sideA * 2) + (sideB * 2);
        }

        public double Area() 
        {
            return sideA * sideB;
        }
    }
}
