using System;
using System.Collections.Generic;
using System.Text;

namespace ZooPark
{
    public class Animal
    {
      
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public string color { get; set; }
        public string MakeSound { get; set; }
        public float AnimalHeight { get; set; }
        public AnimalType TypeOfAnimal { get; set; }

        public bool isHungry { get; set; }
        public bool isAlive { get; set; }

        /*If you want to use the Eat() method in the base classes, we need to use override in derived class.
         *To override in base class, the Eat() method in parent(base) class need to be virtual
         * virtual void Eat() --- In parent(base) class
         * overide void Eat() --- In derived class
         */

        public virtual void Eat()
        {
            Console.WriteLine("I eat food");
        }

    }

    //Enumuration of Animal type, that contains herbivore and carnivore

    public enum AnimalType
    {
        herbivore,
        carnivore
    }
}
