using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsInterfacePractice
{
    public interface Character
    {
        String Base
        {
            get { return "character"; }
            set { }
        }
        public void attack();
        public void heal();
        public String getWeapon();
    }
}
