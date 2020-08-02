using _020820.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020820.Shapes
{
    class Circle : IDraw3D
    {
        private double _radius;
        public double GetRadius()
        {
            return _radius;
        }
        public void DrawIn3D()
        {
            throw new NotImplementedException();
        }
    }
}
