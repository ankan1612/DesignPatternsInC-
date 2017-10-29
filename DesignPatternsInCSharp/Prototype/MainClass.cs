using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Prototype
{
    class MainClass
    {
        public static void Main()
        {
            EmployeeManager em = new EmployeeManager();
            em["Joe"] = new Employee("Joe", "Blow");
            em["David"] = new Employee("David", "Brown");

            Employee newEmp1 = em["Joe"].Clone() as Employee;
            newEmp1.PrintDetails();

            Console.ReadKey();
        }
    }
}
