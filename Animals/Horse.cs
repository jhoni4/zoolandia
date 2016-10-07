using System;

namespace Zoolandia.Animals
{
    class Horse: Animal
    {
        public Horse(string nickname, int legs = 4) {
               Name= "hoho";
               SpeciesName="horsieooo";
               Wings=false;
               Sound="wieeee";
           }
        public override string sleep() {
          return "it sleeps while standing.";
        }
         public void process() {
              Console.WriteLine($"I have a Horse named {this.Name} of Species Name {this.SpeciesName} \n who makes a noise that sounds like {this.Sound}.\n {this.sleep()} ");
            }


    }
}