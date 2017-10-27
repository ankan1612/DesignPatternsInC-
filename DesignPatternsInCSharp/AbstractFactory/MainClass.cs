using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.AbstractFactory
{
    //Testing abstract factory implementation
    class MainClass
    {
        public static void Main()
        {
            //create habitat 1
            IHabitatFactory habitat1 = new HabitatFactory1();
            Jungle jungle = new Jungle(habitat1);
            jungle.FoodChain();

            //create habitat 2
            IHabitatFactory habitat2 = new HabitatFactory2();
            jungle = new Jungle(habitat2);
            jungle.FoodChain();

            Console.ReadKey();
        }

    }
}
