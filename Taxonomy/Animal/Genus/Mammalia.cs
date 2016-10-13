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
        //overloading
         public void walky(string commonName) {
              Console.WriteLine($"{this.commonName} is a good walker");
        }
      //   


    }
}









      