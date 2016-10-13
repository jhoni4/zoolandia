using System;




namespace Zoolandia
{
    class Ostich: Animal
    {
        public Ostich(string nickname, bool flying) {
               this.commonName= "Ostich";
               this.nickname= nickname;
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
          Console.WriteLine("usually they eat plants.");
        }


    }
}




