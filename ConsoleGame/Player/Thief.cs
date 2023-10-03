using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Player
{
    public class Thief : Players
    {
        private int armor = 0;
        private int healthPoint = 0;

        public int Armor { get { return armor; } set { armor = value; } }
        public int HealthPoint { get { return healthPoint; } set { healthPoint = value; } }


        public override void ShowPlayer()
        {
            Armor = Dexterity / 2;
            HealthPoint = Survivability * 4;
            Console.WriteLine($"Тип героя - вор. \n" +
                $"Имя: {Name}. Сила: {Force}.\n");
            Console.WriteLine($"Ловкость = {Dexterity}. Броня = {Armor}\n" +
                $"Живучесть = {Survivability}. Интеллект = {Intelligence}\n. Очки здоровья = {HealthPoint}\n");

        }
    }
}
