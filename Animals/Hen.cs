using System;

namespace Zoolandia.Animals
{
    class Hen: Animal
    {
        public Hen(string nickname, int legs) {
               Name= "kuku";
               SpeciesName="kukiieooo";
               Wings=true;
               Sound="kukuluku";
           }
        public override string sleep() {
          return "it sleeps by siting down.";
        }
         public void process() {
              Console.WriteLine($"I have a Hen named {this.Name} of Species Name {this.SpeciesName} \n who makes a noise that sounds like {this.Sound}.\n {this.sleep()} ");
            }


    }
}




