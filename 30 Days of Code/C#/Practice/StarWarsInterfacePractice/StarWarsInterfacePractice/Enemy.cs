using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsInterfacePractice
{
    class Enemy : Character
    {
        public String weapon = "light saber";

        public Enemy()
        {

        }
        public String getWeapon()
        {
            return weapon;
        }

        public void attack()
        {
            Console.WriteLine("The enemy attack YOU!");
        }

        public void heal()
        {
            Console.WriteLine("The enemy heals himself");
        }

        public void weaponDraw()
        {
            Console.WriteLine("Enemy draws weapon");
        }
    }
}
