using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstMVC.Views
{
    class Display
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double RectangleP { get; set; }
        public double RectangleA { get; set; }

        public Display () 
        {
            SideA = 0;
            SideB = 0;
            RectangleA = 0;
            RectangleP = 0;
            GetValues();
        }

        public void GetValues() 
        {
            Console.Write("Въведи размера страната 'а': ");
            SideA = double.Parse(Console.ReadLine());
            Console.Write("Въведи размера страната 'b': ");
            SideB = double.Parse(Console.ReadLine());
        }

        public void PrintResults() 
        {
            Console.WriteLine("Периметърът е: {0} см.\nЛицето е: {1} кв. см.", RectangleP, RectangleA);
        }
    }
}
