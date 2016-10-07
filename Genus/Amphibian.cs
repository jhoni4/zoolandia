using System;
using Zoolandia.Animals;


namespace Zoolandia.Genus
{
    public class Amphibian : Animal
    {
      
        public bool wings=true;
           
        public virtual string Reproduce(){
            return "since they are Amphibian they give birth to egg.";
        }
        public void process() {
              Console.WriteLine($"I have a {commonname} of Species Name {this.scientificName} \n who makes a noise that sounds like {this.Sound}.\n {this.sleep()} \n and {this.Reproduce()} ");
        }


    }
}