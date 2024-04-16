using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTienda
{
    class NPC : Characters
    {

        public NPC(string name, float hp, float dmg, float ac : base(string name, float hp, float dmg, float ac))
        {
            this.hp = hp;
            this dmg = dmg;
            this ac = ac;
        }

        public virtual float GetHP()
        {
            Console.WriteLine("Selecciona la vida del NPC");
            hp = float.Parse(Console.ReadLine());

            return hp;

        }

        public virtual float GetDMG()
        {
            Console.WriteLine("Selecciona el daño del NPC");
            dmg = float.Parse(Console.ReadLine());

            return dmg;
        }

        public virtual float GetAC()
        {
            Console.WriteLine("Selecciona la defensa del NPC");
            ac = float.Parse(Console.ReadLine());

            return ac;
        }

    }
}
}
