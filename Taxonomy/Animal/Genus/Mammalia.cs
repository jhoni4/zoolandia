using System;


namespace Zoolandia
{
    public class Mammalia : Genus, IAmbulatory
    {

       public Mammalia() {
            this.url= "https://en.wikipedia.org/wiki/Mammalia";
            this.feed="they breastfeed their young";
            this.Reproduce="since they are Mammals they give birth to live young.";
            this.genusName ="Mammalia";
       }
        public virtual string sleepWay() {
          return "They sleeps by lying down";
        }
        //overloading
         public void process(string name) {
              Console.WriteLine($"I have a {this.commonName} named {name}");
        }
      //   


    }
}









      