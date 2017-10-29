using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Singleton
{
    class MainClass
    {
        public static void Main()
        {
            Printer.PrinterInstance.GetDetails();
            Printer.PrinterInstance.GetDetails();
            Printer.PrinterInstance.GetDetails();

            Console.ReadKey();
        }
    }
}
