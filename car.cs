using Acess_mod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    internal class car : typeA
    {
        public car(int _A, int _B, int _c, int _d, int _E, int _F) : base(_A, _B, _c, _d, _E, _F)
        {

        }
        public override string ToString()
        {
            return $"A {A},B {"no"},  C  {C} ,D {"D is internal"} ,E {"private protected "} ,F {F}";
        }
    }
}
