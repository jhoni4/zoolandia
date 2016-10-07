using System;

namespace Zoolandia.Animals
{
    class Dog: Animal
    {
        public Dog(string nickname, int legs = 4) {
               Name= "bobi";
               SpeciesName="dogiieooo";
               Wings=false;
               Sound="woow";
           }
        public override string sleep() {
          return "it sleeps by lying down.";
        }
         public void process() {
              Console.WriteLine($"I have a Dog named {this.Name} of Species Name {this.SpeciesName} \n who makes a noise that sounds like {this.Sound}.\n {this.sleep()} ");
            }


    }
}




