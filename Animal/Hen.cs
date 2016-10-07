using System;

namespace Zoolandia.Animals
{
    class Hen: Animal
    {
        public void Sleep() {
            Console.WriteLine("Hens sleep siting down.");
        }
         public string inform() {
              return $"I have a Hen named {this.Name} Species Name{this.SpeciesName} \n  who makes a noise that sounds like {this.Sound}.";
            }


    }
}




