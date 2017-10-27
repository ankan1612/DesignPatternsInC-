using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Factory
{
    // This is the concrete Product 2
    class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Square has been drawn");
        }
    }
}
