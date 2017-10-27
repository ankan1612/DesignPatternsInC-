using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Factory
{
    // This is the concrete Factory
    class ShapeFactory  : IShapeFactory
    {
        public override IShape getShape(string shapeName)
        {
            switch (shapeName)
            {
                case "circle":
                    {
                        return new Circle();
                    }
                case "square":
                    {
                        return new Square();
                    }
                default:
                    throw new ApplicationException(string.Format("Shape '{0}' cannot be created", shapeName));
            }
        }
    }
}
