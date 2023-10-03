using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Player
{
    public abstract class Players
    {
        private string name;
        private int force;
        private int dexterity;
        private int survivability;
        private int intelligence;

        public string Name { get { return name; } set { name = value; } }
        public int Force { get { return force; } set { force = value; } }
        public int Dexterity { get { return dexterity; } set { dexterity = value; } }
        public int Survivability { get { return survivability; } set { survivability = value; } }
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }
        public Players(string name, int force, int dexterity, int survivability)
        {
            Name = name;
            Force = force;
            Dexterity = dexterity;
            Survivability = survivability;
        }

        public Players()
        {
            ReadPlayer();
        }
        public void ReadPlayer()
        {
            Console.Write("\nИмя героя = ");
            name = Console.ReadLine();
            Console.Write("Сила = ");
            force = int.Parse(Console.ReadLine());
            Console.Write("Ловкость =  ");
            dexterity = int.Parse(Console.ReadLine());
            Console.Write("Живучесть: ");
            survivability = int.Parse(Console.ReadLine());
            Console.Write("Интеллект: ");
            intelligence = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public abstract void ShowPlayer();

    }
}
