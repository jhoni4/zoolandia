using System;
using Zoolandia.Genus;


namespace Zoolandia.Animals
{
    class Ostich: Amphibian
    {
        public Ostich(string nickname, int legs) {
               this.commonname= "Ostich";
               this.scientificName="kukiieooo";
               this.Wings=true;
               this.Sound="kukuluku";
           }
        public override string sleep() {
          return "it sleeps by siting down.";
        }
       


    }
}




