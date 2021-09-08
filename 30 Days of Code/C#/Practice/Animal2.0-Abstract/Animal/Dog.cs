using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal;

namespace Animal
{
    public class Dog : Animal
    {
        public Dog()
        {
            age = 15;
            Console.WriteLine("A dog has been created.");
        }

        public override void eat()
        {
            Console.WriteLine("The dog is eating");
        }

        public void sleep()
        {
            Console.WriteLine("The dog is sleeping");
        }
        public void woof()
        {
            Console.WriteLine("The dog says: woof!");
        }
        public void run()
        {
            Console.WriteLine("The dog is running!");
        }

    }
}
