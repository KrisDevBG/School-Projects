using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skiTrip.Models
{
    class SkiTrip
    {
        private int days;
        private string type;
        private string rate;

        public int Days 
        {
            get { return days; }
            set { days = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public SkiTrip(int days, string type, string rate)
        {
            this.days = days;
            this.type = type;
            this.rate = rate;
        }

        public double HotelPrice() 
        {
            days--;
            double finalPrice = 0;
            switch (type)
            {
                case "room for one person":
                    finalPrice = days * 18;
                    break;
                case "apartment":
                    finalPrice = days * 25;
                    if (days < 10)
                    {
                        finalPrice -= (finalPrice * 0.3);
                    } 
                    else if (days >= 10 && days <= 15)
                    {
                        finalPrice -= (finalPrice * 0.35);
                    }
                    else
                    {
                        finalPrice -= (finalPrice * 0.5);
                    }
                    break;
                case "president apartment":
                    finalPrice = days * 35;
                    if (days < 10)
                    {
                        finalPrice -= (finalPrice * 0.1);
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        finalPrice -= (finalPrice * 0.15);
                    }
                    else
                    {
                        finalPrice -= (finalPrice * 0.2);
                    }
                    break;
                default:
                    break;
            }

            if (rate == "positive")
            {
                finalPrice += (finalPrice * 0.25);
            }
            else
            {
                finalPrice -= (finalPrice * 0.1);
            }

            return finalPrice;
        }
    }
}
