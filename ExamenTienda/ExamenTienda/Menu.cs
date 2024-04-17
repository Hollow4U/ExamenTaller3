using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTienda
{
    class Menu
    {
        private bool continueFlag = true;

        private List<NPC> NPCs;
        private List<Items> items;
        Player name = new Player("Vendedor", 0, 0, 0);

        public Menu()
        {
            NPCs = new List<NPC>();
            items = new List<Items>();
        }

        public void Execute()
        {

            CreatePlayer();


            while (continueFlag)
            {
                Console.WriteLine("Introducir la funcion que quieres realizar");
                Console.WriteLine("1. Crear Personajes");
                Console.WriteLine("2. Crear Objetos");
                Console.WriteLine("3. Listar datos");
                Console.WriteLine("4. Agregar a inventario");
                Console.WriteLine("5. Terminar programa");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CreateNPC();
                        break;
                    case 2:
                        CreateObject();
                        break;
                    case 3:
                        ListData();
                        break;
                    case 4:
                        AddToInventory();
                        break;
                    case 5:
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Esa opcion no existe");
                        break;
                }
            }
        }

        public void CreatePlayer()
        {
            name.GetHP();
            name.GetDMG();
            name.GetAC();
        }

        public void CreateNPC()
        {
            Console.WriteLine("Introducir el personaje que quieras crear");
            Console.WriteLine("1. Enemigo");
            Console.WriteLine("2. Hablador");
            Console.WriteLine("3. Comprador");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Enemy enemy = new Enemy("Enemigo", 0, 0, 0);
                    enemy.GetName();
                    enemy.GetHP();
                    enemy.GetDMG();
                    enemy.GetAC();
                    NPCs.Add(enemy);
                    break;
                case 2:
                    Yappers yapper = new Yappers("Hablador", 0, 0, 0);
                    yapper.GetName();
                    yapper.GetHP();
                    yapper.GetDMG();
                    yapper.GetAC();
                    NPCs.Add(yapper);
                    break;
                case 3:
                    Buyers buyer = new Buyers("Comprador", 0, 0, 0);
                    buyer.GetName();
                    buyer.GetHP();
                    buyer.GetDMG();
                    buyer.GetAC();
                    NPCs.Add(buyer);
                    break;
                default:
                    Console.WriteLine("Esa opcion no existe");
                    break;
            }
        }

        public void CreateObject()
        {
            Console.WriteLine("Introducir el objeto que quieres crear:");
            Console.WriteLine("1. Arma");
            Console.WriteLine("2. Pocion");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Weapons weapon = new Weapons("Arma", 0);
                    weapon.GetName();
                    weapon.GetPrice();
                    items.Add(weapon);
                    break;
                case 2:
                    Potions potion = new Potions("Pocion", 0);
                    potion.GetName();
                    potion.GetPrice();
                    items.Add(potion);
                    break;
                default:
                    Console.WriteLine("Esa opcion no existe");
                    break;
            }
        }

        public void ListData()
        {
            Console.WriteLine("Introducir los datos que quieres listar:");
            Console.WriteLine("1. Jugador");
            Console.WriteLine("2. NPCs");
            Console.WriteLine("3. Objetos");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine($"El {name.name} tiene HP:{name.hp} DMG:{name.dmg} DEF:{name.ac}");
                    Console.WriteLine("En el inventario tiene:");
                    foreach (Items item in name.inventory)
                    {
                        Console.WriteLine($"{item.name}");
                    }
                    break;

                case 2:
                    foreach (NPC npc in NPCs)
                    {
                        Console.WriteLine($"{npc.name} HP:{npc.hp} DMG: {npc.dmg} DEF: {npc.ac}");
                        Console.WriteLine("En el inventario tiene:");
                        foreach (Items item in npc.inventory)
                        {
                            Console.WriteLine($"{item.name}");
                        }
                    }
                    break;
                case 3:
                    foreach (Items item in items)
                    {
                        Console.WriteLine($"{item.name} con valor de : {item.price} soles");
                    }
                    break;
                default:
                    Console.WriteLine("Esa opcion no existe");
                    break;
            }
        }

        public void AddToInventory()
        {
            Console.WriteLine("¿A que tipo de personaje quieres agregarle un objeto a su inventario?");
            Console.WriteLine("1. Jugador");
            Console.WriteLine("2. NPCs");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("¿Que objeto quieres añadirle al jugador?");
                    foreach (Items items in items)
                    {
                        Console.WriteLine($"{items.name}");
                    }

                    int eleccion = int.Parse(Console.ReadLine());

                    if (option >= 0)
                    {
                        name.addItem(items[eleccion]);
                    };
                    break;

                case 2:
                    AddToNPC();
                    break;

                default:
                    Console.WriteLine("Esa opcion no existe");
                    break;
            }
        }

        public void AddToNPC()
        {
            Console.WriteLine("¿A que NPC quieres agregarle un objeto?");
            foreach (NPC npc in NPCs)
            {
                Console.WriteLine($"{npc.name}");
            }

            int option = int.Parse(Console.ReadLine());

            if (option >= 0)
            {
                Console.WriteLine("¿Que objeto quieres añadirle al npc?");
                foreach (Items items in items)
                {
                    Console.WriteLine($"{items.name}");
                }

                int eleccion = int.Parse(Console.ReadLine());

                if (option >= 0)
                {
                    NPCs[option].addItem(items[eleccion]);
                }
            }
        }
    }
}