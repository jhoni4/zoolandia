using System;

namespace Zoolandia.Animals
{
    class Cat: Animal
    {
        public Cat(string nickname, int legs = 4) {
               Name= "kitty";
               SpeciesName="cateooo";
               Wings=false;
               Sound="miaoow";
           }
        public override string sleep() {
          return "it sleeps by lying down.";
        }
         public void process() {
              Console.WriteLine($"I have a cat named {Name} of Species Name {this.SpeciesName} \n who makes a noise that sounds like {this.Sound}.\n {this.sleep()} ");
            }


    }
}




