using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    internal interface IVehicle
    {
        void Start();
        void Accelerate(int speed);
        void Brake();
    }

    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("The car starts.");
        }

        public void Accelerate(int speed)
        {
            Console.WriteLine("The car speed is {0} Kmph.", speed);
        }

        public void Brake()
        {
            Console.WriteLine("The car brakes.");
        }
    }

    class Motorcycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("The motorcycle starts.");
        }

        public void Accelerate(int speed)
        {
            Console.WriteLine("The motorcycle speed is {0} Kmph.", speed);
        }

        public void Brake()
        {
            Console.WriteLine("The motorcycle brakes.");
        }
    }

}
