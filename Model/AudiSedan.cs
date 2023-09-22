using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    internal class AudiSedan : IAudi
    {
        public void Start()
        {
            Console.WriteLine("Audi Sedan starting");
        }

        public void Stop()
        {
            Console.WriteLine("Audi Sedan stopping");
        }
    }
}
