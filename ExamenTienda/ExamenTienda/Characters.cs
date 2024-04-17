using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTienda
{
    class Characters
    {
        public string name;
        public float hp;
        public float dmg;
        public float ac;
        public List <Items> inventory;

        public Characters(string name, float hp, float dmg, float ac)
        {
            this.name = name;
            this.hp = hp;
            this.dmg = dmg;
            this.ac = ac;
            inventory = new List<Items>();
        }


        public void addItem(Items items)
        {
            inventory.Add(items);
        }
    }
}
