using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    abstract class Animal
    {
        public abstract void MakeSound();
        public void Sleep() 
        {
            Console.WriteLine("Sleeping");
        }
    }
}
