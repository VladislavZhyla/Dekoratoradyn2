using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adyn2
{
    class Program
    {
        static void Main(string[] args)
        {
            IMushroom mushroom = new Mushroom("Normal Mushroom", "Small and cool.", 4.99m);

            mushroom = new TruffleMushroom (new PorciniMushroom(mushroom));
          

            Console.WriteLine($"Name: {mushroom.GetName()}");
            Console.WriteLine($"Description: {mushroom.GetDescription()}");
            Console.WriteLine($"Price: {mushroom.GetPrice():C}");
            Console.ReadKey();
        }
    }
}
