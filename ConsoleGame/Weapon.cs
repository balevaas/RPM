using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Weapon
    {
        private string typeWeapon;
        private int damage;
        private int bonus;

        public string TypeWeapon { get { return typeWeapon; } set {  typeWeapon = value; } }
        public int Damage { get { return damage; } set { damage = value; } }
        public int Bonus { get { return bonus; } set { bonus = value; } }

        public Weapon(string typeWeapon, int damage, int bonus)
        {
            TypeWeapon = typeWeapon;
            Damage = damage;
            Bonus = bonus;
        }
    }
}
