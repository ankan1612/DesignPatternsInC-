using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Builder
{
    //This is the product
    class CellPhone
    {
        public string model { get; set; }
        public string processor { get; set; }
        public string memory { get; set; }
        public string camera { get; set; }
        public List<string> accessories { get; set; }

        public CellPhone()
        {
            accessories = new List<string>();
        }

        public void ShowDetails()
        {
            Console.WriteLine("Model: {0}", model);
            Console.WriteLine("Processor: {0}", processor);
            Console.WriteLine("Memory: {0}", memory);
            Console.WriteLine("Camera: {0}", camera);
            Console.WriteLine("Accessories:");
            foreach (var accessory in accessories)
            {
                Console.WriteLine("\t{0}", accessory);
            }
        }
    }
}
