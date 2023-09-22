using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    internal class TeslaSUV : ITesla
    {
        public void Start()
        {
            Console.WriteLine("Tesla SUV starting");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla SUV stopping");
        }
    }
}
