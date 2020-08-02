using _020820.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020820.Furnit
{
    abstract class Furniture : IPaintable
    {
        private double _size;
        public double GetSize()
        {
            return _size;
        }
        public abstract void Paint();

        public static void Measure()
        {

        }
    }
}
