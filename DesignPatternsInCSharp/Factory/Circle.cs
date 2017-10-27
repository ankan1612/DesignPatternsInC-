using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Factory
{
    // This is the concrete Product 1
    class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Circle has been drawn");
        }
    }
}
