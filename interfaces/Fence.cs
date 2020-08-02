using _020820.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020820
{
    class Fence : IPaintable
    {
        public void Paint()
        {
            Console.WriteLine("Painting fence");
        }
    }
}
