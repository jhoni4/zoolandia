using System;

namespace Zoolandia
{
   public class Lion: Animal
    {
        public Lion(string nickname, bool wild, int legs) {
               this.commonName= "Lion";
               this.nickname= nickname;
               this.legs = 4;
               this.scientificName="Lionieooo";
               this.Domestic=false;
               this.sound="brbrbr";
               this.genus = new Mammalia();
        }
        public override void sleepWay() {
          Console.WriteLine("it sleeps lying down.");
        }
        public override void food() {
          Console.WriteLine("usually they eat flesh meat.");
        }
      


    }
}