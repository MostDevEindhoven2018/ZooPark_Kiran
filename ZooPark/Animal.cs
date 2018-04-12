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

        public virtual void Eat()
        {
            Console.WriteLine("I eat food");
        }

    }


    public enum AnimalType
    {
        herbivore,
        carnivore
    }
}
