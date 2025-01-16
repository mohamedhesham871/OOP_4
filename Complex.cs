using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    internal class Complex
    {
        public int real { get; set; }
        public int imaginary { get; set; }


        public override string ToString()
        {
            return $"{real} + {imaginary} i";
        }
        static public Complex operator +(Complex a, Complex b)
        {
            return new Complex()
            {
                real = a.real + b.real,
                imaginary = a.imaginary + b.imaginary
            };
        }
        static public Complex operator ++(Complex a)
        {
            return new Complex()
            {
                real = a.real + 1,
                imaginary= a.imaginary 
            };
        }
            
        
    

    
    }
}
