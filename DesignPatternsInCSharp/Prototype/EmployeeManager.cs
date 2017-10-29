using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Prototype
{
    //This is the prototype manager
    class EmployeeManager
    {
        public Dictionary<string, IEmployee> employees = new Dictionary<string, IEmployee>();

        public IEmployee this[string ID]
        {
            get { return employees[ID]; }
            set { employees.Add(ID, value); }
        }

    }
}
