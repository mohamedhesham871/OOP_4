using OOP_4.Inhertance;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace OOP_4
{
    internal class Program
    {
        #region Overloading
        int sum(int a1, int a2)
        {
            return a1 + a2;
        }

        double sum(double a1, double a2)
        {
            return (a1 + a2);
        }

        string sum(string a1, string a2)
        {
            //concat
            return a1 + a2;
        }
        #endregion

        static void Main(string[] args)
        {
            #region inhertance
            //Inheritance [IS A]
            // single inhertance not mulitple( like Diamond problem)


            /* 
             Parent p1 = new Parent(10, 30);
             Console.WriteLine(p1);
             Console.WriteLine(p1.productNumber());            
             */
            /*
            Child child = new Child(12, 324, 5);     
            Console.WriteLine("---------");
            Console.WriteLine(child);
            Console.WriteLine("----------");
            Console.WriteLine(child.productNumber());
           */
            #endregion
            #region Access
            //Access modifiers
            //1- private
            //2- private protected
            //3- protected
            //4- internal 
            //5- protected internal
            //6- public 

            ////protected best in inheritance project
            //car car = new car(2, 3, 4, 5, 6, 7);
            //// A is public and other no
            //Console.WriteLine(car);

            #endregion

            #region Operator overload
            Complex complex01=new Complex();
            Complex complex02=new Complex();
            complex01.real = 10;
            complex01.imaginary = 3;
            Console.WriteLine(complex01);
            complex02.real = 30;
            complex02.imaginary = 5;
            Console.WriteLine("---------------");

            Console.WriteLine(complex02);
            Console.WriteLine("---------------");
            Complex complex03 =new Complex();
            complex03 = complex01 + complex02;
            Console.WriteLine(complex03);
            complex01++;
            Console.WriteLine(complex01);
            #endregion

        }
    }
}
