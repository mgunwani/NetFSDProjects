/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemonstrations
{
    public interface Animal
    {
        string speak();
    }
    public class Cat: Animal
    {
        public string speak()
        {
            return "Cat - Meow";
        }
    }
    public class Dog : Animal
    {
        public string speak()
        {
            return "Dog - Bark";
        }
    }
    public class Octopus: Animal
    {
        public string speak()
        {
            return "Octopus - Squawck";
        }
    }
    public class Shark: Animal
    {
        public string speak()
        {
            return "Shark - Cannot Speak";
        }
    }

    // Creating Abstract Factory
    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string AnimalType);
        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
            if (FactoryType.Equals("Sea"))
                return new SeaAnimalFactory();
            else if (FactoryType.Equals("Land"))
                return new LandAnimalFactory();
            else
                return null;
        }
    }

    // Creating Concreate Factory
    public class LandAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Dog"))
                return new Dog();
            else if (AnimalType.Equals("Cat"))
                return new Cat();
            else
                return null;
        }
    }
    // Creating Concreate Factory
    public class SeaAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Octopus"))
                return new Octopus();
            else if (AnimalType.Equals("Shark"))
                return new Shark();
            else
                return null;
        }
    }

    class AbstractFactoryPatternImplementation
    {
        public static void Main(string[] args)
        {
            Animal animal = null;
            AnimalFactory animalFactory = null;
            string speakSound = null;
            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory Type : " + animalFactory.GetType().Name);
            animal = animalFactory.GetAnimal("Octopus");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine("Speak Sound of {0} : {1}", animal.GetType().Name, speakSound);
            Console.ReadKey();


        }
    }
}
*/