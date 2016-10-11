using System;


namespace Zoolandia.Animals
{
    public class Amphibian : Genus
    {
      public Amphibian() {
            this.url= "https://en.wikipedia.org/wiki/Amphibian";
            this.feed="they breastfeed their young";
            this.Reproduce="They Reproduce by laying eggs";
            this.genusName="Amphibian";
       }
       public bool wings=true;
        public virtual string sleepWay() {
          return "They sleeps by siting down";
        }
        // public void process() { 
        //     Console.WriteLine($@"Hey I have a {this.commonName} named {this.nickname}
        //     of Species Name {this.scientificName},
        //     Genus Name of {this.genusName}, 
        //     who makes a noise that sounds like {this.sound}
        //     {this.sleepWay()} and {this.Reproduce} ");
        
        // }





    }
}








    //   public Amphibian() {
    //     this.init();
    //   }
    //    public Amphibian(string nickname, double weighs, string foods) {
    //        this.init();
    //        this.nickname = nickname;
    //        this.weight= weighs;
    //        this.food=foods;
    //    }
        // public override string genusName { 
        //     get {
        //         return "amphibian";
        //     }
        // }
       
        // public virtual string canFly(bool flying) {
        //     if (this.flying) {
        //         return "it has wings and they can fly";
        //     }
        //     else {
        //         return "it has wings but they can not fly.";
        //     }
        // }   
        

