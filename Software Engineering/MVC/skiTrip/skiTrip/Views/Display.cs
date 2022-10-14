using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skiTrip.Views
{
    class Display
    {
        public int Days { get; set; }

        public string Type { get; set; }

        public string Rate { get; set; }

        public double FinalPrice { get; set; }

        public Display()
        {
            Days = 0;
            Type = "";
            Rate = "";
            FinalPrice = 0;
            GetValues();
        }

        public void GetValues()
        {
            Console.Write("Въведи дни: ");
            Days = int.Parse(Console.ReadLine());
            Console.Write("Въведи вида на престоя: ");
            Type = Console.ReadLine();
            Console.Write("Въведи оценка на престоя: ");
            Rate = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine("{0:F2} лв.", FinalPrice);
        }
    }
}
