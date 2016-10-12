using System;

namespace Zoolandia
{
    class Hen: Animal
    {
        public Hen(string nickname, bool flying) {
               this.commonName= "hen";
               this.nickname=nickname;
               this.scientificName="kukiieooo";
               this.flying=false;
               this.sound="kukuluku";
               this.genus = new Amphibian();
        }
        // public Genus genus= new Amphibian();
        // public override string sleep() {
        //   return "it sleeps by siting down.";
        // }
        // public override bool canFly = false;


    }
}




