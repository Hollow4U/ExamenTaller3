using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTienda
{
    class Player : Characters
    {

        public Player(string name, float hp, float dmg, float ac : base(string name, float hp, float dmg, float ac))
        {
            name = "Vendedor";
            this.hp = hp;
            this dmg = dmg;
            this ac = ac;
        }

        public virtual float GetHP()
        {
            Console.WriteLine("Selecciona la vida de tu vendedor");
            hp = float.Parse(Console.ReadLine());

            return hp;

        }

        public virtual float GetDMG()
        {
            Console.WriteLine("Selecciona el daño de tu vendedor");
            dmg = float.Parse(Console.ReadLine());

            return dmg;
        }

        public virtual float GetAC()
        {
            Console.WriteLine("Selecciona la defensa de tu vendedor");
            ac = float.Parse(Console.ReadLine());

            return ac; 
        }

    }
}
