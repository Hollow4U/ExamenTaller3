using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTienda
{
    class Potions : Items
    {

        public Potions(string name, float price : base(string name, float price))
        {
            this.name = name;
            this.price = price;

        }

        public virtual float GetName()
        {
            Console.WriteLine("Selecciona el nombre de tu pocion");
            name = Console.ReadLine();

            return name;

        }

        public virtual float GetPrice()
        {
            Console.WriteLine("Selecciona el precio de la pocion");
            price = float.Parse(Console.ReadLine());

            return price;
        }
    }
}
