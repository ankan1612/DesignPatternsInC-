using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.AbstractFactory
{
    // This is the consumer
    class Jungle
    {
        private IHerbivore herbivore;
        private ICarnivore carnivore;

        public Jungle(IHabitatFactory factory)
        {
            herbivore = factory.CreateHerbivore();
            carnivore = factory.CreateCarnivore();
        }

        public void FoodChain()
        {
            carnivore.eat(herbivore);
        }
    }
}
