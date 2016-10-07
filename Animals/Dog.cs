using System;
using Zoolandia.Genus;


namespace Zoolandia.Animals
{
    class Dog: Mammalia
    {
        public Dog(string nickname, bool wild) {
               this.commonname= "dog";
               this.scientificName="dogiieooo";
               this.Domestic=wild;
               this.Sound="woow";
           }
        public override string sleep() {
          return "it sleeps by lying down.";
        }
        public override string breastfeed() {
          return "they do breastfeed but never seen them.";
        }
       


    }
}




