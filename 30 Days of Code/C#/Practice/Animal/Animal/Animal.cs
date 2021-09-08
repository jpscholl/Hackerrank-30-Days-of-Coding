using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animal
    {
        public int age;
        public Animal()
        {
            this.age = age;
            Console.WriteLine("Animal has been created.");
        }

        //getter
        public int getAge()
        {
            return age;
        }

        public void eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }
}
