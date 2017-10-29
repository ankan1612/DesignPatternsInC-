using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Singleton
{
    //This is the singleton class
    class Printer
    {
        private static Printer Instance = null;

        private string Name { get; set; }
        private string IP { get; set; }
        private string Port { get; set; }

        public Printer()
        {
            Name = "HP Officejet";
            IP = "192.168.1.47";
            Port = "8080";
        }

        private static object syncLock = new object();

        public static Printer PrinterInstance
        {
            get
            {
                lock (syncLock)
                {
                    if (Printer.Instance == null)
                        Printer.Instance = new Printer();

                    return Printer.Instance;
                }
            }
        }

        public void GetDetails()
        {
            Console.WriteLine("Printer is : {0} running on : {1}:{2}", Name, IP, Port);
        }



    }
}
