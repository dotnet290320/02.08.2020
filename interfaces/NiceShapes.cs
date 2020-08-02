using _020820.interfaces;
using _020820.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020820
{
    class NiceShapes
    {
        private int x;
        private Circle circle;
        private IDraw3D draw3D;

        public NiceShapes()
        {
            circle = new Circle();
            circle.GetRadius();
            x = 5;

            //draw3D = new Triangle();
            draw3D = new Circle();
            //draw3D = new Canvas();

            object obj = circle;
          

            draw3D.DrawIn3D();
        }

        public NiceShapes(int x, Circle circle, IDraw3D draw3D)
        {
            this.x = x;
            this.circle = circle;
            this.draw3D = draw3D;
        }
    }
}
