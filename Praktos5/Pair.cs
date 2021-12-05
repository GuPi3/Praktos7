using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktos5
{
    class Pair
    {
        public int First { get; set; }
        public int Second { get; set; }
        public Pair()
        {
            First = 0;
            Second = 0;
        }
        public Pair(int firstNumber, int secondNumber)
        {
            First = firstNumber;
            Second = secondNumber;
        }
        //public Pair  Composition(Pair secondPair)
        //{
        //    this.First *=secondPair.First ;
        //    this.Second *=secondPair.Second ;
        //    return this;
        //}
        public static Pair operator *(Pair pair1, Pair pair2)
        {
            pair1.First *= pair2.First;
            pair1.Second *= pair2.Second;
            return pair1;
        }
        public int InternalComposition()
        {
            return First * Second;
        }
    }
}
