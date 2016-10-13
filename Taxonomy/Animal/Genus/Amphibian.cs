using System;


namespace Zoolandia
{
    public class Amphibian : Genus, IFlying
    {
      public Amphibian() {
            this.url= "https://en.wikipedia.org/wiki/Amphibian";
            this.feed="they breastfeed their young";
            this.Reproduce="They Reproduce by laying eggs";
            this.genusName="Amphibian";
       }
    //    public bool wings=true;
         public override void canFly(bool flying) {
            if (flying) {
                Console.WriteLine("it has wings and they can fly");
            }
            else {
                Console.WriteLine("it has wings but they can not fly.");
            }
        } 
 



    }
}









       
       
        

