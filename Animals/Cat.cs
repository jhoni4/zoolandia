using System;

namespace Zoolandia.Animals
{
    public class Cat: Animal
    {
        public Cat() {}
        public override string sleep() {
          return "it sleeps by lying down.";
        }
         public void process() {
              Console.WriteLine($"I have a cat named {this.Name} of Species Name {this.SpeciesName} \n who makes a noise that sounds like {this.Sound}.\n {this.sleep()} ");
            }


    }
}




