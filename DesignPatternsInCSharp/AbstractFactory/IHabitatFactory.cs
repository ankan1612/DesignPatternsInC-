using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.AbstractFactory
{
    // This is abstract factory
    interface IHabitatFactory
    {
        IHerbivore CreateHerbivore();
        ICarnivore CreateCarnivore();
    }
}
