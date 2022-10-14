using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using circleShitMVC.Models;
using circleShitMVC.View;

namespace circleShitMVC.Controllers
{
    class MainControl
    {
        private CircleShitMVC Circle;
        private Display Display;

        public MainControl()
        {
            Display = new Display();
            Circle = new CircleShitMVC(Display.Radius);
            double[] KoreniResult = Circle.Koreni();
            Display.Koreni = KoreniResult[0];
            Display.KoreniPrice = KoreniResult[1];
            double[] BordiuriResult = Circle.Bordiuri();
            Display.Bordiuri = BordiuriResult[0];
            Display.BordiuriPrice = BordiuriResult[1];
            Display.TotalPrice = Circle.TotalPrice();
            Display.Print();
        }
    }
}
