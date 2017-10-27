using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.AbstractFactory
{
    //This is concreate Factory 2
    class HabitatFactory2 : IHabitatFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Zebra();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
