using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    internal class AudiSUV : IAudi
    {
        public void Start()
        {
            Console.WriteLine("Audi SUV Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Audi SUV Stopping");
        }
    }
}
