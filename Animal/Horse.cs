using System;

namespace Zoolandia.Animals
{
    class Horse: Animal
    {
        public void Sleep() {
            Console.WriteLine("Horse sleep stanging.");
        }
         public string inform() {
              return $"I have a Horse named {this.Name} Species Name{this.SpeciesName} \n  who makes a noise that sounds like {this.Sound}.";
            }


    }
}




