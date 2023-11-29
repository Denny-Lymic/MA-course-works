using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    class Customer
    {
        // 6) declare private field name

        private string name;

        // 7) declare constructor to initialize name

        public Customer(string name)
        {
            this.name = name;
        }

        // 8) declare method GotNewGoods with 2 parameters:
        // 1 - object type
        // 2 - GoodsInfoEventArgs type

        public void GotNewGoods(object obj, GoodsInfoEventArgs newGoods)
        {
            Console.WriteLine("Yo, new items appeared - {0} for customer {1}", newGoods.GoodsName, name);
        }
    }
}
