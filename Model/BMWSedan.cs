using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    internal class BMWSedan : IBMW
    {
        public void Start()
        {
            Console.WriteLine("BMW Sedan starting");
        }

        public void Stop()
        {
            Console.WriteLine("BMW Sedan stopping");
        }
    }
}
