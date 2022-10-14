using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleShitMVC.Models
{
    class CircleShitMVC
    {
        double radius;
        double priceForKoreni = 0;
        double priceForBordiuri = 0;
        public double Radius {
            get { return radius; }
            set { radius = value; } 
        }

        public CircleShitMVC(double radius)
        {
            Radius = radius;
        }

        public CircleShitMVC() : this(0) { }

        public double Area() 
        {
            return Math.PI * (radius * radius);
        }

        public double Circumference()
        {
            return 2 * Math.PI * radius;
        }

        public double[] Koreni() 
        {
            double totalKoreni = Area() * 20;
            priceForKoreni = totalKoreni * 1.5;
            double[] result = { totalKoreni, priceForKoreni };

            return result;
        }

        public double[] Bordiuri() 
        {
            double totalBordiuri = Circumference() * 4;
            priceForBordiuri = totalBordiuri * 1.25;
            double[] result = { totalBordiuri, priceForBordiuri };

            return result;
        }

        public double TotalPrice()
        {
            return priceForBordiuri + priceForKoreni;
        }
     }
}
