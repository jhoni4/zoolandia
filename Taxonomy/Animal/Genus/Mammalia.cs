using System;


namespace Zoolandia.Animals
{
    public class Mammalia : Genus
    {
          //  public Mammalia genus = new Mammalia();

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









      // public Mammalia() {
      //   this.init();
      // }
      //  public Mammalia(string nickname, double weighs) {
      //      this.init();
      //      this.nickname = nickname;
      //      this.weight= weighs;
      //  }
      //   overriding
      //   public override string genusName { 
      //       get {
      //           return "Mammalia";
      //       }
      //   }



      //   public void process(){
      //          Console.WriteLine($@"Hi I have a {this.commonName} 
      //         named {this.nickname}, weighs {this.weighs}
      //         Scientific Name of {this.scientificName} 
      //         Genus Name of {this.genusName} 
      //         who makes a noise that sounds like {this.sound}.
      //         {this.sleepWay()} and {this.feed} 
      //         Also {this.Reproduce}");
      //   }