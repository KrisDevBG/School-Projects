using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comissions.Views
{
    class Display
    {
        public string City { get; set; }

        public double Sells { get; set; }

        public double Comission { get; set; }

        public Display()
        {
            City = "";
            Sells = 0;
            Comission = 0;
            GetValues();
        }

        public void GetValues()
        {
            Console.Write("Въведи град: ");
            City = Console.ReadLine();
            Console.Write("Въведи продажбите: ");
            Sells = double.Parse(Console.ReadLine());
        }

        public void Print()
        {
            if (Comission == -1)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:F2}", Comission);
            }
        }
    }
}
