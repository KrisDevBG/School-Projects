using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleShitMVC.View
{
    class Display
    {
        public double Radius { get; set; }

        public double Koreni { get; set; }

        public double KoreniPrice { get; set; }

        public double Bordiuri { get; set; }

        public double BordiuriPrice { get; set; }

        public double TotalPrice { get; set; }

        public Display()
        {
            Radius = 0;
            Koreni = 0;
            KoreniPrice = 0;
            Bordiuri = 0;
            BordiuriPrice = 0;
            TotalPrice = 0;
            GetValues();
        }
        
        public void GetValues() 
        {
            Console.Write("Въведи радиуса на кръговото: ");
            Radius = double.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Корени - {0:F2} | Цена - {1:F2} лв.", Koreni, KoreniPrice);
            Console.WriteLine("Бордюри - {0:F2} | Цена - {1:F2} лв.", Bordiuri, BordiuriPrice);
            Console.WriteLine("Обща цена - {0:F2} лв.", TotalPrice); ;
        }
    }
}
