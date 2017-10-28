using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Builder
{
    class MainClass
    {
        public static void Main()
        {
            CellPhoneCreator cellPhoneCreator = new CellPhoneCreator(new Apple());
            cellPhoneCreator.CreateCellPhone();
            CellPhone apple = cellPhoneCreator.GetCellPhone();
            apple.ShowDetails();

            Console.WriteLine("---------------------------------------------");

            cellPhoneCreator = new CellPhoneCreator(new Samsung());
            cellPhoneCreator.CreateCellPhone();
            CellPhone samsung = cellPhoneCreator.GetCellPhone();
            samsung.ShowDetails();

            Console.ReadKey();
        }
    }
}
