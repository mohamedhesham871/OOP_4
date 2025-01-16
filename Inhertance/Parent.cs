using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Inhertance
{
    internal class Parent
    {
        
        public int x { get; set; }
        public int y { get; set; }

        // make constructor
      public Parent(int _x,int _y)
        {
            x = _x;
            y = _y;
        }
        // should make function virtual to make override in chlid
        public virtual int productNumber()
        { return x*y; }

        
        public override string ToString()
        {
            return $"x is {x} Y is {y}";
        }
    }
}
