using System;
using Zoolandia.Genus;


namespace Zoolandia.Animals
{
   public class Cat: Mammalia
    {
        public Cat(string nickname, bool wild) {
            this.commonname= "cat";
            this.scientificName="cateooo";
            this.Domestic=wild;
            this.Sound="miaoow";
           }
        public Cat (string nickname) {
            this.commonname = nickname;
        }
        public override string sleep() {
          return "it sleeps by lying down.";
        }
        public override string breastfeed() {
          return "they do breastfeed.";
        }
         


    }
}




