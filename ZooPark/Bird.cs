using System;
using System.Collections.Generic;
using System.Text;

namespace ZooPark
{
    public class Bird : Animal
    {
        public int NumberOfWings { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Ï eat insects");
        }

    }

    public class Owl : Bird
    {
        public Owl()
        {
            base.TypeOfAnimal = AnimalType.carnivore;
            base.NumberOfWings = 2;
        }
        public Owl(string name, float height)
        {
            base.TypeOfAnimal = AnimalType.carnivore;
            base.NumberOfLegs = 4;
            base.Name = name;
            base.AnimalHeight = height;

            Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat small insects and fishes\n");
        }

    }

    public class Penguin : Bird
    {
        public Penguin()
        {
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfWings = 2;
        }
        public Penguin(string name, float height)
        {
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfLegs = 4;
            base.Name = name;
            base.AnimalHeight = height;

            Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat algae\n");
        }

    }

    public class Parrot : Bird
    {

        public Parrot()
        {
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfWings = 2;
        }
        public Parrot(string name, float height)
        {
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfLegs = 4;
            base.Name = name;
            base.AnimalHeight = height;

            Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I only eat seeds\n");
        }

    }

}
