using System;

namespace Zoolandia.Animals
{
    public class Hen: Animal
    {
        public Hen() {}
        public override string sleep() {
          return "it sleeps by siting down.";
        }
         public void process() {
              Console.WriteLine($"I have a Hen named {this.Name} of Species Name {this.SpeciesName} \n who makes a noise that sounds like {this.Sound}.\n {this.sleep()} ");
            }


    }
}




