using System;
using System.Collections.Generic;
using System.Text;

namespace ZooPark
{
    public class Reptiles : Animal
    {
        
    }

    public class Shark : Reptiles, Icarnivore
    {
        public Shark()
        {
            base.TypeOfAnimal = AnimalType.carnivore;
            base.NumberOfLegs = 0;
        }

        //constructor with input parameters

        public Shark(string name, float height) : this()
        {
            //base.NumberOfLegs = 0;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat only fishes\n");
        }

        //Icarnivore Interface method implementation

        public void EatMeat()
        {
            Console.WriteLine("I eat only meat");
        }

    }

    public class Dolphin : Reptiles, Iherbivore
    {
        public Dolphin()
        {
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfLegs = 0;
        }

        //constructor with input parameters

        public Dolphin(string name, float height):this()
        {
            //base.NumberOfLegs = 0;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat only algae not the fishes\n");
        }

        //Iherbivore Interface method implementation

        public void EatGrass()
        {
            Console.WriteLine("I eat only grass");
        }
    }

    public class Chameleon : Reptiles, Iherbivore
    {
        public Chameleon()
        {
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfLegs = 0;
        }

        //constructor with input parameters

        public Chameleon(string name, float height):this()
        {
            //base.NumberOfLegs = 0;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat only algae not the fishes\n");
        }

        //Iherbivore Interface method implementation

        public void EatGrass()
        {
            Console.WriteLine("I eat only grass");
        }
    }

    public class Aligator : Reptiles, Icarnivore
    {
        public Aligator()
        {
            base.TypeOfAnimal = AnimalType.carnivore;
            base.NumberOfLegs = 4;
        }

        //constructor with input parameters

        public Aligator(string name, float height):this()
        {
            //base.NumberOfLegs = 0;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat all kinds of fishes\n");
        }

        //Icarnivore Interface method implementation

        public void EatMeat()
        {
            Console.WriteLine("I eat only meat");
        }

    }
}
