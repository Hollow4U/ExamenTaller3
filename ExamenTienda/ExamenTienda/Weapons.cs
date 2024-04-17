using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTienda
{
    class Weapons : Items
    {
        public Weapons(string name, float price) : base(name, price)
        {

        }

        public virtual string GetName()
        {
            Console.WriteLine("Selecciona el nombre de tu arma");
            name = Console.ReadLine();

            return name;

        }

        public virtual float GetPrice()
        {
            Console.WriteLine("Selecciona el precio del arma");
            price = float.Parse(Console.ReadLine());

            return price;
        }

    }
}

