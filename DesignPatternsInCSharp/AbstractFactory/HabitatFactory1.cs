using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.AbstractFactory
{
    //This is concreate Factory 1
    class HabitatFactory1 : IHabitatFactory
    {
        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }
        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
