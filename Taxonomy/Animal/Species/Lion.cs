using System;

namespace Zoolandia
{
   public class Lion: Animal
    {
        public Lion(string nickname, bool wild) {
               this.commonName= "Lion";
               this.nickname= nickname;
               this.scientificName="Lionieooo";
               this.Domestic=false;
               this.sound="brbrbr";
               this.genus = new Mammalia();
        }
        // public Genus genus= new Mammalia();
        // public override string sleep() {
        //   return "it sleeps lying down.";
        // }
      


    }
}