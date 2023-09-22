using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    internal class BMWSUV : IBMW
    {
        public void Start()
        {
            Console.WriteLine("BMW SUV Starting");
        }

        public void Stop()
        {
            Console.WriteLine("BMW SUV Stopping");
        }
    }
}
