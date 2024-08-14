using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Item
    {
        private string _name;
        private float _price;
        private int _amount;

        public Item(string name, float price, int amount)
        {
            _name = name;
            _price = price;
            _amount = amount;
        }

        public void AddItem(int amount)
        {
            _amount += amount;
        }
    }
}
