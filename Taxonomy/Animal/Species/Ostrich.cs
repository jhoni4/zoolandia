using System;




namespace Zoolandia
{
    class Ostich: Animal
    {
        public Ostich(string nickname, bool flying) {
               this.commonName= "Ostich";
               this.nickname= nickname;
               this.scientificName="kukiieooo";
               this.flying=false;
               this.sound="kukuluku";
               this.genus = new Amphibian();

        }
        // public Genus genus= new Amphibian();
        // public override string sleep() {
        //   return "it sleeps by siting down.";
        // }
       


    }
}




