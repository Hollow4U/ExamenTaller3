using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTienda
{
    class Items
    {
        protected string name;
        protected float price;

        public Items(string name, float price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
