using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public abstract class Animal
    {
        public int age;
        public Animal()
        {
            this.age = age;
            Console.WriteLine("Animal has been created.");
        }

        public abstract void eat();

        public void sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }

        //getter
        public int getAge()
        {
            return age;
        }

        
    }
}
