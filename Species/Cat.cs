using System;

namespace Zoolandia.Species
{
    public class Cat: Animal
    {
        public Cat() {}
        public void Sleep() {
            Console.WriteLine("Cats sleep lying down.");
        }
         public void inform() {
              Console.WriteLine($"I have a {this.Name} named Nutsy of Species Name{this.SpeciesName} \n  who makes a noise that sounds like {this.Sound}.");
            }


    }
}




