using System;

namespace Zoolandia.Animals
{
    class Cat: Animal
    {
        public void Sleep() {
            Console.WriteLine("Cats sleep lying down.");
        }
         public string inform() {
              return $"I have a cat named {this.Name} of Species Name {this.SpeciesName} \n  who makes a noise that sounds like {this.Sound}.";
            }


    }
}




