using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Factory
{
    class MainClass
    {
        public static void Main()
        {
            IShapeFactory factory = new ShapeFactory();
            IShape circle = factory.getShape("circle");
            circle.draw();
            IShape square = factory.getShape("square");
            square.draw();

            Console.ReadKey();
        }
    }
}
