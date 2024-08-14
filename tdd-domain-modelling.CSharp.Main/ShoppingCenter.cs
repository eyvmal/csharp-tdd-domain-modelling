using System;
using System.Collections.Generic;
using System.Data;
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

        public List<string> Receipt(List<Item> cart)
        {
            List<string> receipt = new List<string>();

            foreach (Item item in cart)
            {
                var amount = item.GetAmount();
                var name = item.GetName();
                var price = item.GetPrice();
                var total = amount * price;
                receipt.Add($"{amount}x {name} - {total}kr");
            }

            return receipt;
        }
    }
}
