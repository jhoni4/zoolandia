using System;
using Zoolandia.Genus;


namespace Zoolandia.Animals
{
    class Eagle: Animal
    {
        public Eagle(string nickname, int legs) {
               commonname= "Eagle";
               scientificName="Eaglieooo";
               Wings=true;
               Sound="ikiki";
           }
        public override string sleep() {
          return "it sleeps by siting down.";
        }
         public void process() {
              Console.WriteLine($"I have a  {this.commonname} of Species Name {this.scientificName} \n who makes a noise that sounds like {this.Sound}.\n {this.sleep()} ");
            }


    }
}




