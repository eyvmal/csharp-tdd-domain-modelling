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
            float total = 0f;
            foreach (Item item in cart)
            {
                total += item.GetPrice() * item.GetAmount();
            }
            return total;
        }

        public Receipt Receipt(List<Item> cart)
        {
            return new Receipt();
        }
    }
}
