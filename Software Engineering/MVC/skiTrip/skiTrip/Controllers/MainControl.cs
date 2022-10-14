using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using skiTrip.Models;
using skiTrip.Views;

namespace skiTrip.Controllers
{
    class MainControl
    {
        private SkiTrip trip;
        private Display display;

        public MainControl()
        {
            display = new Display();
            trip = new SkiTrip(display.Days, display.Type, display.Rate);
            display.FinalPrice = trip.HotelPrice();
            display.Print();
        }
    }
}
