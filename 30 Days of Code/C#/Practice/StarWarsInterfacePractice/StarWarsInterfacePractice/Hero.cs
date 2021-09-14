using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsInterfacePractice
{
    class Hero : Character
    {
        public String weapon = "the force";

        public Hero()
        {

        }
        public String getWeapon()
        {
            return weapon;
        }
        public void attack()
        {
            Console.WriteLine("The hero attacks the enemy!");
        }

        public void heal()
        {
            Console.WriteLine("The hero heals you");
        }

        public void weaponDraw()
        {
            Console.WriteLine("You draw your weapon");
        }
    }
}
