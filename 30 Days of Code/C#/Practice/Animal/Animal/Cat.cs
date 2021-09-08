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
        public void meow()
        {
            Console.WriteLine("Cat says: Meow!");
        }
        public void hunting()
        {
            Console.WriteLine("Is stalking a mouse");
        }
    }
}
