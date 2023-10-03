using ConsoleGame.Player;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.ShowPlayer();
            Console.WriteLine();
            Thief thief = new Thief();
            thief.ShowPlayer();
            Console.WriteLine();
            Mage mage = new Mage();
            mage.ShowPlayer();
        }
    }
}