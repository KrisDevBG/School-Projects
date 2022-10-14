using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstMVC.Model;
using firstMVC.Views;

namespace firstMVC.Controllers
{
    class MainControl
    {
        private Rectangle rectangle;
        private Display display;

        public MainControl()
        {
            display = new Display();
            rectangle = new Rectangle(display.SideA, display.SideB);
            display.RectangleP = rectangle.Perimeter();
            display.RectangleA = rectangle.Area();
            display.PrintResults();
        }
    }
}
