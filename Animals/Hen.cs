using System;
using Zoolandia.Genus;


namespace Zoolandia.Animals
{
    class Hen: Amphibian
    {
        public Hen(string nickname, int legs) {
               this.commonname= "hen";
               this.scientificName="kukiieooo";
               this.Wings=true;
               this.Sound="kukuluku";
           }
        public override string sleep() {
          return "it sleeps by siting down.";
        }
       


    }
}




