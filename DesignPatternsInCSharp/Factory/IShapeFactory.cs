using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Factory
{
    // This is the abstract Factory
    abstract class IShapeFactory
    {
        public abstract IShape getShape(string shapeName);
    }
}
