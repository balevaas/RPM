using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Player
{
    public class Mage : Players
    {
         
        private int magicPoint;
        private int magicArmor;

        
        public int MagicPoint { get { return magicPoint; } set { magicPoint = value; } }
        public int MagicArmor { get { return magicArmor; } set { magicArmor = value; } }


        public override void ShowPlayer()
        {
            MagicArmor = Intelligence / 2;
            MagicPoint = Intelligence * 4;

            Console.WriteLine($"Тип героя - маг. \n" +
                $"Имя: {Name}. Сила: {Force}.\n");
            Console.WriteLine($"Ловкость = {Dexterity}. Броня = {MagicArmor}\n" +
                $"Живучесть = {Survivability}." +
                $"Интеллект = {Intelligence} \n. Очки здоровья = {MagicPoint}\n");

        }
    }
}
