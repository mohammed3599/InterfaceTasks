using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    interface IAnimal
    {
        void Eat();
        void Sleep();
    }

    class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The dog eats a meat.");
        }

        public void Sleep()
        {
            Console.WriteLine("The dog sleeps on the sofa.");
        }
    }

    class Cat : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The cat eats a mouse.");
        }

        public void Sleep()
        {
            Console.WriteLine("The cat sleeps on the ground.");
        }
    }
}
