using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlya2kursa
{
    public class Car
    {
        public string brand;
        public int year_issue;
        public string color;
        public string transmission;
        public int price;
        public Car(string brand, int year_issue, string color, string transmission, int price)
        {
            this.brand = brand;
            this.year_issue = year_issue;
            this.color = color;
            this.transmission = transmission;
            this.price = price;
        }
    }
}
