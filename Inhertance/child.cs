using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Inhertance
{
    internal class Child:Parent
    {
      public int C {  get; set; }

        //make constructor chaning on parent
        public Child(int x, int y, int _c) : base(x, y)
        {
            C = _c;
        }

        /*new -->without  virtual keyword*/
        public override int productNumber()
        {
            return base.productNumber()*C;
        }

        public override string ToString()
        {
            return base.ToString() +$" C is {C}";
        }
    }
}
