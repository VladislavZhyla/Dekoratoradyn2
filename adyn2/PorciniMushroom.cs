using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adyn2
{
    public class PorciniMushroom : MushroomDecorator
    {
        public PorciniMushroom(IMushroom mushroom) : base(mushroom)
        {
        }

        public override string GetName()
        {
            return $"{mushroom.GetName()} with porcini";
        }

        public override string GetDescription()
        {
            return $"{mushroom.GetDescription()} with porcini";
        }

        public override decimal GetPrice()
        {
            return mushroom.GetPrice() + 2.50m;
        }
    }
}
