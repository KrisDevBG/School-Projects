using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comissions.Models;
using comissions.Views;

namespace comissions.Controllers
{
    class MainControl
    {
        private Comissions Comission;
        private Display Display;

        public MainControl()
        {
            Display = new Display();
            Comission = new Comissions(Display.City, Display.Sells);
            Display.Comission = Comission.TotalComissions();
            Display.Print();
        }
    }
}
