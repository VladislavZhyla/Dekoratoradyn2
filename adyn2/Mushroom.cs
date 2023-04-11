using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adyn2
{
    public class Mushroom:IMushroom
    {
            private string name;
            private string description;
            private decimal price;

            public Mushroom(string name, string description, decimal price)
            {
                this.name = name;
                this.description = description;
                this.price = price;
            }

            public string GetName()
            {
                return name;
            }

            public string GetDescription()
            {
                return description;
            }

            public decimal GetPrice()
            {
                return price;
            }
        
    }
}
