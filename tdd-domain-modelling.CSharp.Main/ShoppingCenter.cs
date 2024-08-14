using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class ShoppingCenter
    {
        public ShoppingCenter() { }

        public float Checkout(List<Item> cart)
        {
            return 0;
        }

        public Receipt Receipt(List<Item> cart)
        {
            return new Receipt();
        }
    }
}
