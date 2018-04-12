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

    public class Owl : Bird, Icarnivore
    {
        public Owl()
        {
            base.TypeOfAnimal = AnimalType.carnivore;
            base.NumberOfWings = 2;
            isHungry = true;
        }
        public Owl(string name, float height):this()
        {
            //base.TypeOfAnimal = AnimalType.carnivore;
            //base.NumberOfLegs = 2;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat small insects and fishes\n");
        }
        public void EatMeat()
        {
            Console.WriteLine("I eat meat");

        }

    }

    public class Penguin : Bird, Iherbivore
    {
        public Penguin()
        {
            isHungry = false;
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfWings = 2;
        }
        public Penguin(string name, float height):this()
        {
            //base.TypeOfAnimal = AnimalType.herbivore;
            //base.NumberOfLegs = 2;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat algae\n");
        }

        public void EatGrass()
        {
            Console.WriteLine("I eat only grass");
        }

    }

    public class Parrot : Bird,Iherbivore
    {

        public Parrot()
        {
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfWings = 2;
        }
        public Parrot(string name, float height):this()
        {
            //base.TypeOfAnimal = AnimalType.herbivore;
            //base.NumberOfLegs = 2;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I only eat seeds\n");
        }

        public void EatGrass()
        {
            Console.WriteLine("I eat only grass");
        }

    }

}
