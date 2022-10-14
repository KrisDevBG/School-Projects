using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comissions.Models
{
    class Comissions
    {
        private string city;
        private double sells;

        public string City { get { return city; } set { city = value; } }

        public double Sells { get { return sells; } set { sells = value; } }

        public Comissions(string city, double sells)
        {
            this.city = city;
            this.sells = sells;
        }

        public double TotalComissions()
        {
            double comission = 0;
            switch (city)
            {
                case "Sofia":
                    if (sells >= 0 && sells <= 500)
                    {
                        comission = sells * 0.05;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comission = sells * 0.07;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comission = sells * 0.08;
                    }
                    else if (sells > 10000)
                    {
                        comission = sells * 0.12;
                    }
                    else
                    {
                        comission = -1;
                    }
                    break;

                case "Varna":
                    if (sells >= 0 && sells <= 500)
                    {
                        comission = sells * 0.045;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comission = sells * 0.075;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comission = sells * 0.1;
                    }
                    else if (sells > 10000)
                    {
                        comission = sells * 0.13;
                    }
                    else
                    {
                        comission = -1;
                    }
                    break;
                case "Plovdiv":
                    if (sells >= 0 && sells <= 500)
                    {
                        comission = sells * 0.055;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comission = sells * 0.08;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comission = sells * 0.12;
                    }
                    else if (sells > 10000)
                    {
                        comission = sells * 0.145;
                    }
                    else
                    {
                        comission = -1;
                    }
                    break;
                default:
                    comission = -1;
                    break;
            }

            return comission;
        }
    }
}
