using System;
using Zoolandia.Animals;


namespace Zoolandia.Genus
{
    public class Mammalia : Animal
    {
        // overriding
        public virtual string breastfeed() {
          return "they breastfeed their young";
        }
        public virtual string Reproduce(){
            return "since they are Mammals they give birth to live young.";
        }
        public void process() {
              Console.WriteLine($"I have a {this.commonname} of scientificName Name {this.scientificName} \n who makes a noise that sounds like {this.Sound}.\n {this.sleep()} and {this.breastfeed()} \n And {this.Reproduce()} ");
        }
        //overloading
        public void process(string name) {
              Console.WriteLine($"I have a {name} of scientificName Name ");
        }


    }
}