using System;

namespace Zoolandia
{
    class Hen: Animal
    {
        public Hen(string nickname, bool flying, int legs) {
               this.commonName= "hen";
               this.nickname=nickname;
               this.legs = 2;
               this.scientificName="kukiieooo";
               this.flying=false;
               this.sound="kukuluku";
               this.genus = new Amphibian();
        }
        public override void sleepWay() {
          Console.WriteLine("it sleeps by siting down.");
        }
       public override void food() {
          Console.WriteLine("usually they eat cereals.");
        }


    }
}




