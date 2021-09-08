using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Cat : Animal
    {
        public Cat(int age)
        {
            this.age = age;
            Console.WriteLine("Cat has been created");
        }

        public override void eat()
        {
            Console.WriteLine("The cat is eating");
        }
        public void sleep()
        {
            Console.WriteLine("The cat is sleeping");
        }
        public void meow()
        {
            Console.WriteLine("The cat says: Meow!");
        }
        public void hunting()
        {
            Console.WriteLine("The cat is stalking a mouse");
        }

    }
}
