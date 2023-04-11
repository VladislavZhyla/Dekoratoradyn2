using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adyn2
{
    public abstract class MushroomDecorator : IMushroom
    {
        protected IMushroom mushroom;

        public MushroomDecorator(IMushroom mushroom)
        {
            this.mushroom = mushroom;
        }

        public virtual string GetName()
        {
            return mushroom.GetName();
        }

        public virtual string GetDescription()
        {
            return mushroom.GetDescription();
        }

        public virtual decimal GetPrice()
        {
            return mushroom.GetPrice();
        }
    }
}
