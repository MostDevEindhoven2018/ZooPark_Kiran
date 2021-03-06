﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZooPark
{
    public class Mammal : Animal
    {
       

    }

    //interface Icarnivore
    //{
    //    void EatMeat();
    //}

    //public interface Iherbivore
    //{
    //    float EatPlants();
    //}

    public class Lion : Mammal, Icarnivore
    {      
        
       public Lion()
        {
            isHungry = true;
            TypeOfAnimal = AnimalType.carnivore;   
            NumberOfLegs = 4;
        }

        //constructor with input parameters
        //this() will inherit the properties from the default constructor public Lion()

        public Lion (string name,float height): this()
        {
            //base.TypeOfAnimal = AnimalType.carnivore;
            //base.NumberOfLegs = 4;
            Name = name;
            AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        //this("lion",20.5f) will inherit the properties from public Lion (string name,float height)

        public Lion(int numberOfLegs) : this("lion",20.5f)
        {

        }

        //Icarnivore Interface method implementation

        public void EatMeat()
        {
            Console.WriteLine("I eat meat");

        }

    }

    public class Tiger : Mammal, Icarnivore
    {
        public Tiger()
        {
            isHungry = false;
            base.TypeOfAnimal = AnimalType.carnivore;
            base.NumberOfLegs = 4;
        }

        //constructor with input parameters

        public Tiger(string name, float height):this()
        {
            //base.TypeOfAnimal = AnimalType.carnivore;
            //base.NumberOfLegs = 4;
            base.Name = name;
            base.AnimalHeight = height;

           // Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        //The overide, overrides the Eat() method from Animal

        public override void Eat()
        {
            Console.WriteLine("I eat all other animals\n");
        }

        //Icarnivore Interface method implementation

        public void EatMeat()
        {
            Console.WriteLine("I eat meat");

        }

    }

    public class Leopard : Mammal, Icarnivore
    {
        public Leopard()
        {
            base.TypeOfAnimal = AnimalType.carnivore;
            base.NumberOfLegs = 4;
        }

        //constructor with input parameters

        public Leopard(string name, float height):this()
        {
            //base.TypeOfAnimal = AnimalType.carnivore;
            //base.NumberOfLegs = 4;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat all other kind of animals\n");
        }

        //Icarnivore Interface method implementation

        public void EatMeat()
        {
            Console.WriteLine("I eat meat");

        }

    }

    public class Giraffe : Mammal, Iherbivore
    {
        public Giraffe()
        {
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfLegs = 4;
        }

        //constructor with input parameters

        public Giraffe(string name, float height):this()
        {
            //base.TypeOfAnimal = AnimalType.carnivore;
            //base.NumberOfLegs = 4;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat only grass\n");
        }

        //Iherbovore Interface method implementation

        public void EatGrass()
        {
            Console.WriteLine("I eat only grass");
        }

    }

    public class Sheep : Mammal, Iherbivore
    {
        public Sheep()
        {
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfLegs = 4;
        }

        //constructor with input parameters

        public Sheep(string name, float height):this()
        {
            //base.TypeOfAnimal = AnimalType.carnivore;
            //base.NumberOfLegs = 4;
            base.Name = name;
            base.AnimalHeight = height;

            //Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat only grass\n");
        }

        //Iherbivore Interface method implementation

        public void EatGrass()
        {
            Console.WriteLine("I eat only grass");
        }
    }
}
