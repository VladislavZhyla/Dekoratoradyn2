using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adyn2
{
    public class TruffleMushroom : MushroomDecorator
    {
        public TruffleMushroom(IMushroom mushroom) : base(mushroom)
        {
        }

        public override string GetName()
        {
            return $"{mushroom.GetName()} with truffle,";
        }

        public override string GetDescription()
        {
            return $"{mushroom.GetDescription()} with truffle,";
        }

        public override decimal GetPrice()
        {
            return mushroom.GetPrice() + 3.50m;
        }
    }
}
