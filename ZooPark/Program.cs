using System;
using System.Collections.Generic;
using System.Linq;

namespace ZooPark.world
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Bird bird = new Bird();
            //bird.Eat();
            

            //Lion lion = new Lion("Kiran",75.0f);
            //parrot parrot = new parrot();



            List<Animal> zoo = new List<Animal>();
            zoo.Add(new Lion());
            zoo.Add(new Lion("lion1", 85.02f));
            zoo.Add(new Leopard());
            zoo.Add(new Tiger());
            zoo.Add(new Tiger("Tiger1",52.55f));
            zoo.Add(new Giraffe());
            zoo.Add(new Giraffe("Giraffe1", 216.87f));
            zoo.Add(new Sheep());
            zoo.Add(new Sheep("sheep1", 53.5f));

            zoo.Add(new Shark());
            zoo.Add(new Dolphin());
            zoo.Add(new Dolphin("Dolphin",56.5f));
            zoo.Add(new Aligator());
            zoo.Add(new Chameleon());
            zoo.Add(new Chameleon("chameleon", 4.5f));

            zoo.Add(new Penguin());
            zoo.Add(new Owl());
            zoo.Add(new Parrot());
            zoo.Add(new Parrot("parrot",11.2f));

            //Console.WriteLine(zoo[1].GetType().BaseType);

            int numberOfMammals = 0; int numberOfReptiles = 0; int numberOfBirds = 0;


            for (int i = 0; i < zoo.Count; i++)
            {

                //compare list tye to class type

                if (zoo[i].GetType().BaseType == typeof(Mammal))
                {
                    numberOfMammals++;
                }

                else if (zoo[i].GetType().BaseType == typeof(Reptiles))
                {
                    numberOfReptiles++;
                }

                else if (zoo[i].GetType().BaseType == typeof(Bird))
                {
                    numberOfBirds++;
                }

                //if (zoo[i].GetType() == typeof(Lion) || zoo[i].GetType() == typeof(Tiger) ||
                //    zoo[i].GetType() == typeof(Leopard) || zoo[i].GetType() == typeof(Giraffe)
                //    || zoo[i].GetType() == typeof(Sheep))
                //{
                //    numberOfMammals++;
                //}

                //else if (zoo[i].GetType() == typeof(Shark) || zoo[i].GetType() == typeof(Dolphin) ||
                //    zoo[i].GetType() == typeof(Aligator) || zoo[i].GetType() == typeof(Chameleon))
                //{
                //    numberOfReptiles++;
                //}

                //else if (zoo[i].GetType() == typeof(Parrot) || zoo[i].GetType() == typeof(Owl) ||
                //    zoo[i].GetType() == typeof(Penguin))
                //{
                //    numberOfBirds++;
                //}

            }

            Console.WriteLine($"ZooPark contains {numberOfMammals} mammals.");
            Console.WriteLine($"ZooPark contains {numberOfReptiles} Reptiles.");
            Console.WriteLine($"ZooPark contains {numberOfBirds} Birds.\n");

            List<Animal> carnivoreAnimals = zoo.Where(animal => animal.TypeOfAnimal == AnimalType.carnivore).ToList();
            //var lis =zoo.OfType<AnimalType.>

            //List<Animal> carnivoreAnimals = new List<Animal>();

            //for (int i = 0; i < zoo.Count; i++)
            //{
            //    if(zoo[i].TypeOfAnimal == AnimalType.carnivore)
            //    {
            //        carnivoreAnimals.Add(zoo[i]);
            //    }

            //}

            Console.WriteLine("The carnivore animals in ZOO are: ");

            for (int i = 0; i < carnivoreAnimals.Count; i++)
            {
                Console.Write($"{carnivoreAnimals[i]}\n");
            }

            List<Animal> herbivoreAnimals = zoo.Where(animal => animal.TypeOfAnimal == AnimalType.herbivore).ToList();

            //List<Animal> herbivoreAnimals = new List<Animal>();

            //for (int i = 0; i < zoo.Count; i++)
            //{
            //    if (zoo[i].TypeOfAnimal == AnimalType.herbivore)
            //    {
            //        herbivoreAnimals.Add(zoo[i]);
            //    }

            //}

            Console.WriteLine("\nThe herbivore animals in ZOO are: ");

            for (int i = 0; i < herbivoreAnimals.Count; i++)
            {
                Console.Write($"{herbivoreAnimals[i]}\n");
            }


            //int CountOfHerbivore = 0;
            //int CountOfCarnivore = 0;
            //foreach (Animal animal in zoo)
            //{
            //    //Console.WriteLine($"I am {animal.GetType()} {animal.TypeOfAnimal} type called as {animal.Name}.....has {animal.NumberOfLegs} legs");
            //    //animal.Eat();
            //    if(animal.TypeOfAnimal == AnimalType.herbivore)
            //    {
            //        CountOfHerbivore++;
            //    }

            //    else if (animal.TypeOfAnimal == AnimalType.carnivore)
            //    {
            //        CountOfCarnivore++;
            //    }

            //}
            //Console.WriteLine($"\nIn total ZooPark contains {CountOfHerbivore} herbivore animals.");
            //Console.WriteLine($"In total ZooPark contains {CountOfCarnivore} carnivore animals.\n");

            Console.WriteLine($"\nIn total ZooPark contains {carnivoreAnimals.Count} carnivore animals.");
            Console.WriteLine($"In total ZooPark contains {herbivoreAnimals.Count} herbivore animals.\n");

            Console.Write("ZOO provide food to animals (Y/N): ");
            string UserInput = Console.ReadLine();

            if (UserInput.Equals("Y") || UserInput.Equals("y"))
            {
                Console.WriteLine("All herbivore and carnivore are safe :) :) :)");
            }

            else if (UserInput.Equals("N") || UserInput.Equals("n"))
            {
                Console.WriteLine("Cranivore animals hunts herbivores...\n..hunting...\n...hunting...\n....hunting...\n.....hunting...");

                for (int i = 0; i < carnivoreAnimals.Count; i++)
                {
                    if (herbivoreAnimals.Count > 0)
                    {                     
                        Console.Write("Carnivore are hunting herbivore, do the ZOO still provide food (Y/N) [[Default response in No]]: ");
                        string input1 = Console.ReadLine();

                        if (input1 == "Y" || input1 == "y")
                        {
                            Console.WriteLine("Thank you :) for providing th food and Animals are safe\n");
                            break;
                        }

                        else if (input1 == "N" || input1 == "n")
                        {
                            herbivoreAnimals.RemoveAt(0);
                            Console.WriteLine($"1 herbivore is killed and number of herbivor remained is : {herbivoreAnimals.Count}");
                           
                        }

                        else
                        {
                            input1 = Console.ReadLine();
                            herbivoreAnimals.RemoveAt(0);
                            Console.WriteLine($"1 herbivore is killed and number of herbivor remained is : {herbivoreAnimals.Count}");
                        }

                    }
                    
                    else if (herbivoreAnimals.Count <= 0)
                    {

                        Console.WriteLine("\nAll herbivores are dead and carnivore animals are starving");

                        Console.Write("\nAll herbivores are dead, do the ZOO still provide food (Y/N): ");
                        string input2 = Console.ReadLine();

                        if (input2 == "Y" || input2 == "y")
                        {
                            Console.WriteLine("All carnivores are safe\n");
                            break;
                        }

                        if (input2 == "N" || input2 == "n")
                        {
                            //Console.WriteLine($"carnivore count is: {carnivoreAnimals.Count}");

                            carnivoreAnimals.Clear();
                            //for (int a = 0; a < carnivoreAnimals.Count; a++)
                            //{
                            //    carnivoreAnimals.RemoveAt(0);
                            //}

                            Console.WriteLine("All carnivores are starved and died\n ");
                        }

                    }
                }

                

                //for (int i = 0; i < zoo.Count; i++)
                //{
                //    if (zoo[i].TypeOfAnimal == AnimalType.carnivore)
                //    {
                //        CountOfHerbivore--;

                //        if (CountOfHerbivore<=0)
                //        {
                //            break;
                //        }

                //    }


                //}

                Console.WriteLine($"The final count of carnivore in ZOO is {carnivoreAnimals.Count}");
                Console.WriteLine($"The final count of herbivore in ZOO is {herbivoreAnimals.Count}");
            }

            
            Console.ReadKey();
        }
    }
}
