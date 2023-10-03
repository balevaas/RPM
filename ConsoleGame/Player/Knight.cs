using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Player
{
    public class Knight : Players
    {
        private int armor = 2;
        private int healthPoint = 15;

        public int Armor { get { return armor; } set { armor = value; } }
        public int HealthPoint { get { return healthPoint; } set { healthPoint = value; } }


        public override void ShowPlayer()
        {
            Armor = Dexterity / 2;
            HealthPoint = Survivability * 4;
            Console.WriteLine($"Тип героя - главный игрок. \n" +
                $"Имя: {Name}. Сила: {Force}.\n");
            Console.WriteLine($"Ловкость = {Dexterity}. Броня = {Armor}\n" +
                $"Живучесть = {Survivability}. Интеллект = {Intelligence}.\n Очки здоровья = {HealthPoint}\n");

        }
    }
}
