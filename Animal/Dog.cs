using System;

namespace Zoolandia.Animals
{
    class Dog: Animal
    {
        public void Sleep() {
            Console.WriteLine("Dogs sleep lying down.");
        }
         public string inform() {
              return $"I have a Dog named {this.Name} of Species Name{this.SpeciesName} \n  who makes a noise that sounds like {this.Sound}.";
            }


    }
}




