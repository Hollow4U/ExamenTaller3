using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTienda
{
    class Buyers : NPC
    {
        public Buyers(string name, float hp, float dmg, float ac) : base(name, hp, dmg, ac)
        {
        }

        public virtual string GetName()
        {
            Console.WriteLine("Escribe el nombre del comprador");
            name = Console.ReadLine();

            return name;
        }

        public override float GetHP()
        {
            Console.WriteLine("Selecciona la vida del NPC");
            hp = float.Parse(Console.ReadLine());

            return hp;
        }

        public override float GetDMG()
        {
            Console.WriteLine("Selecciona el daño del NPC");
            dmg = float.Parse(Console.ReadLine());

            return dmg;
        }

        public override float GetAC()
        {
            Console.WriteLine("Selecciona la defensa del NPC");
            ac = float.Parse(Console.ReadLine());

            return ac;
        }
    }
}
