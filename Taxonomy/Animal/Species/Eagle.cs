using System;


namespace Zoolandia
{
    class Eagle: Animal
    {
        public Eagle(string nickname, bool flying, int legs) {
               this.commonName= "Eagle";
               this.nickname= nickname;
               this.legs = 2;
               this.scientificName="Eaglieooo";
               this.flying=true;
               this.sound="ikiki";
               this.genus = new Amphibian();
        }

        public override void sleepWay() {
          Console.WriteLine("it sleeps by siting down.");
        }
        public override void food() {
          Console.WriteLine("usually they eat fish.");
        }


    }
}




