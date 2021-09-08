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
        public void woof()
        {
            Console.WriteLine("Dog says: woof!");
        }
        public void run()
        {
            Console.WriteLine("Dog is running!");
        }
    }
}
