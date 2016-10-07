using System;
using Zoolandia.Genus;


namespace Zoolandia.Animals
{
   public class Lion: Mammalia
    {
        public Lion(string nickname, bool wild) {
               this.commonname= "Lion";
               this.scientificName="Lionieooo";
               this.Domestic=wild;
               this.Sound="brbrbr";
           }
        public override string sleep() {
          return "it sleeps lying down.";
        }
      


    }
}