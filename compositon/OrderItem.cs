using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.compositon
{
    internal class OrderItem
    {
       public int Id { get; set; }
        //composition
       public required product product { get; set; }

        //public OrderItem(product _product)
        //{
        //    product = _product;
        //}
    }
}
