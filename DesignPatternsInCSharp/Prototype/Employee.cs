using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Prototype
{
    //This is the concrete prototype class
    class Employee : IEmployee
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Employee(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        public void PrintDetails()
        {
            Console.WriteLine("{0} {1}", FirstName, LastName);
        }
    }
}
