using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    class Bird : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Cuckoo");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }
}
