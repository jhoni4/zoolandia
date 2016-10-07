using System;

namespace Zoolandia.Animals
{
    public class Horse: Animal
    {
        public Horse() {}
        public override string sleep() {
          return "it sleeps while standing.";
        }
         public void process() {
              Console.WriteLine($"I have a Horse named {this.Name} of Species Name {this.SpeciesName} \n who makes a noise that sounds like {this.Sound}.\n {this.sleep()} ");
            }


    }
}