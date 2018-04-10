using System;
using System.Collections.Generic;
using System.Text;

namespace ZooPark
{
    public class Reptiles : Animal
    {
        
    }

    public class Shark : Reptiles
    {
        public Shark()
        {
            base.TypeOfAnimal = AnimalType.carnivore;
            base.NumberOfLegs = 0;
        }
        public Shark(string name, float height)
        {
            base.NumberOfLegs = 0;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat only fishes\n");
        }

    }

    public class Dolphin : Reptiles
    {
        public Dolphin()
        {
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfLegs = 0;
        }
        public Dolphin(string name, float height)
        {
            base.NumberOfLegs = 0;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat only algae not the fishes\n");
        }

    }

    public class Chameleon : Reptiles
    {
        public Chameleon()
        {
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfLegs = 0;
        }
        public Chameleon(string name, float height)
        {
            base.NumberOfLegs = 0;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat only algae not the fishes\n");
        }

    }

    public class Aligator : Reptiles
    {
        public Aligator()
        {
            base.TypeOfAnimal = AnimalType.carnivore;
            base.NumberOfLegs = 4;
        }
        public Aligator(string name, float height)
        {
            base.NumberOfLegs = 0;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat all kinds of fishes\n");
        }

    }
}
