using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktos5
{
    internal class Rectangle : Pair
    {
        public Rectangle() : base()
        {

        }
        public int PerimeterCalculations()
        {
            return (First + Second) * 2;
        }
        public int RectangleArea()
        {
            return First * Second;
        }
    }
}
