using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTienda
{
    class Yappers : NPC
    {
        public Yappers(string name, float hp, float dmg, float ac : base(string name, float hp, float dmg, float ac))
        {
            this.name = name;
            this.hp = hp;
            this dmg = dmg;
            this ac = ac;
        }
        public virtual string GetName()
        {
            Console.WriteLine("Escribe el nombre del hablador");
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
